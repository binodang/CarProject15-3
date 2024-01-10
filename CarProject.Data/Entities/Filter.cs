namespace CarProject.Data.Entities;

public class Filter : IEntety
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string TypeName { get; set; }
    public OptionType OptionType { get; set; }
    public List<Category>? Categories { get; set; }
}