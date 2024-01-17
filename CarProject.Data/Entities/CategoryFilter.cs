namespace CarProject.Data.Entities;
public class CategoryFilter
{
    public int FilterId { get; set; }
    public Filter Filter { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}