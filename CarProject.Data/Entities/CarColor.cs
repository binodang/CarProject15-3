﻿namespace CarProject.Data.Entities;

public class CarColor
{
    public int CarId { get; set; }
    public Car Car { get; set; }
    public int ColorId { get; set; }
    public Color Color { get; set; }
}
