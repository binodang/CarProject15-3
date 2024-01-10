namespace CarProject.Data.Entities;

public class Price : IEntety
{
    public int Id { get; set; }
    public decimal CarPrice { get; set; }
    public OptionType OptionType { get; set; }

}