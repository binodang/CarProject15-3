namespace CarProject.Data.Entities;
public class Brand : IEntety
{
    public int Id { get; set; }
    public string Name { get; set; }
    public OptionType OptionType { get; set; }
    public List<Brand>? Brands { get; set; }
}