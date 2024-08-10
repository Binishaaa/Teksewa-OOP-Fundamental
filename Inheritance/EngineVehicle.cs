public class EngineVehicle : Vehicle, IVehicle
{
    public EngineVehicle(string number,float mileage, float cc)
    :base(number)
    {
        Mileage = mileage;
        EngineCC = cc;
    }
    public float EngineCC {get; set; }
    public float Mileage {get;set; }
    public float GetDistanceCovered(float oilUsed) => Mileage * oilUsed;
}

//class- inheritant // interface-implementation