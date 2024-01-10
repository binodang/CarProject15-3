namespace CarProject.Data.Entities;

public class Category : IEntety
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Car>? Cars { get; set; }

}