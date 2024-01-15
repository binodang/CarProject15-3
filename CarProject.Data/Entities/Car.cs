namespace CarProject.Data.Entities;

//Car = Product
public class Car : IEntety
{
    public int Id { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }

    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    public int VehicleTypeId { get; set; }
    public VehicleType VehicleType { get; set; }

    
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    
    public int ColorId { get; set; }
    public Color Color { get; set; }
}