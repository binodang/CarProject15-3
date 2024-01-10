namespace CarProject.Data.Entities;

//Car = Product
public class Color : IEntety
{
    public int Id { get; set; }
    public string Name { get; set; }
    public OptionType OptionType { get; set; }
    public List<Color>? Colors { get; set; }
}