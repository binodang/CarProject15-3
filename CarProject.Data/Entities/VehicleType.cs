namespace CarProject.Data.Entities;

//Car Size
public class VehicleType : IEntety
{
    public int Id { get; set; }
    public string Name { get; set; }
    public OptionType OptionType { get; set; }
    public List<VehicleType>? VehicleTypes { get; set; }

}
