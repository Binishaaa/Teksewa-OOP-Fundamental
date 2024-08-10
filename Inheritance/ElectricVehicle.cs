public class ElectricVehicle: Vehicle, IVehicle //Vehicle - base class, IVehicle -  interface
{
    public ElectricVehicle(string number,short range, float batterycapacity) //constructor
    : base(number)
    {
       Range = range;
       BatteryCapacity = batterycapacity; 
    }
    public float BatteryCapacity {get; set; }
    public short Range {get; set; }

    public float GetDistanceCovered(float batteryUsedPercentage) => Range/100 * batteryUsedPercentage;
}
