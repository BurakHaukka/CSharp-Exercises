public class Vehicle
{
    public string Brand { get; set; } // Maker
    public string Model { get; set; } // Model of the vehicle
    public int Speed { get; set; } // Max speed can achieve
    public int Tires { get; set; } // Tire code????

    public virtual string ShowInfo()
    {
        return $"Vehicle is made by {Brand} and model is {Model}";
    }

    public override string ToString()
    {
        return $"Vehicle is made by {Brand},\n\nModel is {Model},\n\nTop speed {Speed} km/h,\n\nTire code {Tires}";
    }
}

public class VehicleType : Vehicle
{
    public string Type { get; set; } // Type of the vehicle Car, motorcycle, truck etc.

    public override string ToString()
    {
        return base.ToString() + "\n\nType of the vehicle is " + Type.ToString() + ".";

    }
}



internal class Program
{
    private static void Main(string[] args)
    {
      
        // Make some vehicles
        VehicleType vehicle1 = new VehicleType() { Brand = "VOLVO", Model = "A60H", Speed = 55, Tires = 1001 };
        vehicle1.Type = "Articulated Hauler";

        VehicleType vehicle2 = new VehicleType() { Brand = "FIAT", Model = "Linea", Speed = 200, Tires = 0001 };
        vehicle2.Type = "Passenger";

        VehicleType vehicle3 = new VehicleType() { Brand = "DUCATI", Model = "Monster SP", Speed = 225, Tires = 0003 };
        vehicle3.Type = "Motorbike";
       
        // Vehicle collection
        List<Vehicle> VehicleList = new List<Vehicle>();
        VehicleList.Add(vehicle1);
        VehicleList.Add(vehicle2);
        VehicleList.Add(vehicle3);

        Console.WriteLine("===================================================\n\nPrinting Manufacturer and Model\n\n");
        foreach (var item in VehicleList)
        {
            Console.WriteLine(item.ShowInfo());
        }
        Console.WriteLine("\n\n===================================================\n\nPrinting Detailed Information\n\n===================================================\n\n");

        foreach (var item in VehicleList)
        {
            Console.WriteLine(item.ToString());
            Console.WriteLine("\n=========================\n");
        }


    }
}