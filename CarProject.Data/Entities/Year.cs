namespace CarProject.Data.Entities;
public class Year : IEntety
{
    public int Id { get; set; }
    public int YearModel { get; set; }
    public OptionType OptionType { get; set; }
   
}