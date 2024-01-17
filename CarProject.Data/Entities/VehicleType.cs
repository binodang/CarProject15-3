namespace CarProject.Data.Entities;

public class VehicleType : IEntety
{
    public int Id { get; set; }
    public int VehicleId { get; set; }
    public OptionType OptionType { get; set; }
    public List<Car>? Cars { get; set; }
}

