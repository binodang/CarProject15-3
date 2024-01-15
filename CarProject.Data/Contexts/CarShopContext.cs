using CarProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarProject.Data.Contexts;

public class CarShopContext(DbContextOptions<CarShopContext> options) : DbContext(options)
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
        // Varje Car är kopplad till en Brand, och varje Brand kan ha många Cars.
        builder.Entity<Car>()
            .HasOne(c => c.Brand)
            .WithMany(b => b.Cars)
            .HasForeignKey(c => c.BrandId);

        // En-till-Många Relationship: Car till VehicleType
        // Varje Car är kopplad till ett VehicleType, och varje VehicleType kan ha många Cars.
        builder.Entity<Car>()
            .HasOne(c => c.VehicleType)
            .WithMany(vt => vt.Cars)
            .HasForeignKey(c => c.VehicleTypeId);

        // En-till-Många Relationship: Car till Category
        // Varje Car är kopplad till en Category, och varje Category kan ha många Cars.
        builder.Entity<Car>()
            .HasOne(c => c.Category)
            .WithMany(cat => cat.Cars)
            .HasForeignKey(c => c.CategoryId);

        // En-till-Många Relationship: Car till Color
        // Varje Car är kopplad till en Color, och varje Color kan ha många Cars.
        builder.Entity<Car>()
            .HasOne(c => c.Color)
            .WithMany(col => col.Cars)
            .HasForeignKey(c => c.ColorId);

        builder.Entity<CarCategory>()
        .HasKey(cc => new { cc.CarId, cc.CategoryId });

        builder.Entity<CarColor>()
        .HasKey(cc => new { cc.CarId, cc.ColorId });


    }



}
