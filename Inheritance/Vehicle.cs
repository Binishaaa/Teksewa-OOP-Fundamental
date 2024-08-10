
public abstract class Vehicle
{
    //constructor
    public Vehicle(string number)
    {
        vehicleNumber = number;
    }
    string vehicleNumber;
    public string VehicleNumber //VehicleNumber property uses vehicleNumber field
     {
        get => vehicleNumber;
        set{
            if(value != "" && value.Length > 5)
                vehicleNumber = value;
        } 
    }

    public string Brand {get; set; } = "";
    public DateTime Year {get; set; }
    public VehicleType Type {get; set; } = VehicleType.Wagon; //here VehicleType(VehicleType.cs) is enum :: fixed derived from VehiclType.cs
}
