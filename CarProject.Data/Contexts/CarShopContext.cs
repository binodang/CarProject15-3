using CarProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarProject.Data.Contexts;

public class CarShopContext(DbContextOptions<CarShopContext> builder) : DbContext(builder)
{
    public DbSet<Brand> Brands => Set<Brand>();
    public DbSet<Car> Cars => Set<Car>();
    public DbSet<CarCategory> CarCategories => Set<CarCategory>();
    public DbSet<Color> Colors => Set<Color>();
    public DbSet<CarColor> CarColors => Set<CarColor>();
    public DbSet<Filter> Filters => Set<Filter>();
    public DbSet<CategoryFilter> CategoryFilters => Set<CategoryFilter>();
    public DbSet<VehicleType> VehicleTypes => Set<VehicleType>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // En-till-Många Relationship: Car till Brand
        builder.Entity<Car>()
            .HasOne(c => c.Brand)
            .WithMany(b => b.Cars)
            .HasForeignKey(c => c.BrandId);

        // En-till-Många Relationship: Car till VehicleType
        builder.Entity<Car>()
            .HasOne(c => c.VehicleType)
            .WithMany(vt => vt.Cars)
            .HasForeignKey(c => c.VehicleTypeId);

        // Många-till-Många Relationship: Car till Category
        builder.Entity<Car>()
            .HasMany(c => c.Categories)
            .WithMany(cat => cat.Cars)
            .UsingEntity<CarCategory>(
                j => j
                    .HasOne(cc => cc.Category)
                    .WithMany(cat => cat.CarCategories)
                    .HasForeignKey(cc => cc.CategoryId),
                j => j
                    .HasOne(cc => cc.Car)
                    .WithMany(c => c.CarCategories)
                    .HasForeignKey(cc => cc.CarId),
                j => j.HasKey(cc => new { cc.CarId, cc.CategoryId }));

        // Många-till-Många Relationship: Car till Color
        builder.Entity<Car>()
            .HasMany(c => c.Colors)
            .WithMany(col => col.Cars)
            .UsingEntity<CarColor>(
                j => j
                    .HasOne(cc => cc.Color)
                    .WithMany(col => col.CarColors)
                    .HasForeignKey(cc => cc.ColorId),
                j => j
                    .HasOne(cc => cc.Car)
                    .WithMany(c => c.CarColors)
                    .HasForeignKey(cc => cc.CarId),
                j => j.HasKey(cc => new { cc.CarId, cc.ColorId }));

        builder.Entity<CategoryFilter>()
    .HasKey(cf => new { cf.CategoryId, cf.FilterId });
    }



}
