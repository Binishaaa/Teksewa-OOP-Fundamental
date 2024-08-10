// Vehicle vehicle = new Vehicle();
// vehicle.VehicleNumber = "BA PA 2344";
// var x = vehicle.vehicleNumber;

// VehicleNumber = "BA PA 1122";
// Brand = "Electric";
// BatteryCapacity = 76.0f;
// float distance = 210.0f;
// float batteryUsedPercentage = 20.0f;


//Modify instantiation process

//EV = number, range, batterycapacity
IVehicle car1 = new ElectricVehicle("BA PA 3232",435,45.9f);
Console.WriteLine(car1.GetDistanceCovered(20f));

//Engine = number, mileage, cc
IVehicle car2 =  new EngineVehicle("BA PA 1122",456.5f,200f);
Console.WriteLine(car2.GetDistanceCovered(20f));