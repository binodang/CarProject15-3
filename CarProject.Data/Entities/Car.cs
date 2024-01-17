﻿namespace CarProject.Data.Entities;

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

    public List<CarColor> CarColors { get; set; }
    public List<CarCategory> CarCategories { get; set; }
    public List<Category>? Categories { get; set; }
    public List<Color>? Colors { get; set; }
}