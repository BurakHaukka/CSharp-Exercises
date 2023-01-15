using System.Diagnostics.Contracts;
using System.Net.Http.Headers;

internal class Program
{
    public class Car 
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int TireNumber 
        {
            get { return Tires.Count; } 
        }

        public List<Tire> Tires { get; set; }

        public virtual string ToString()
        {
            return $"\nCar: {Model}-{Brand} has tire installed: {TireNumber}.\n";
        }

    }

    public class Tire 
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string TireSize { get; set; }

        public override string ToString() 
        {
            return $"Manufacturer: {Manufacturer}, Model: {Model}, Tire Size: {TireSize}";
        }
    }
    private static void Main(string[] args)
    {
        Car polo = new Car() { Brand = "VW", Model = "Polo" };
        polo.Tires = new List<Tire>();
        
        Tire tire1 = new Tire() { Manufacturer = "Prelli", Model = "Model 1", TireSize = "205/45R16"};
        Tire tire2 = new Tire() { Manufacturer = "Prelli", Model = "Model 1", TireSize = "205/45R16" };
        Tire tire3 = new Tire() { Manufacturer = "Prelli", Model = "Model 1", TireSize = "205/45R16" };
        Tire tire4 = new Tire() { Manufacturer = "Prelli", Model = "Model 1", TireSize = "205/45R16" };

        polo.Tires.Add(tire1);
        polo.Tires.Add(tire2);
        polo.Tires.Add(tire3);
        polo.Tires.Add(tire4);

        Console.WriteLine(polo.ToString());

        foreach (Tire item in polo.Tires) 
        {
            Console.WriteLine(item.ToString());
        }


        Tire tire5 = new Tire() { Manufacturer = "LastikSA", Model = "Model 3", TireSize = "05/R16" };
        Tire tire6 = new Tire() { Manufacturer = "LastikSA", Model = "Model 3", TireSize = "05/R16" };
        Tire tire7 = new Tire() { Manufacturer = "LastikSA", Model = "Model 3", TireSize = "05/R16" };
        Tire tire8 = new Tire() { Manufacturer = "LastikSA", Model = "Model 3", TireSize = "05/R16" };

        polo.Tires.Clear();
        polo.Tires.Add(tire5);
        polo.Tires.Add(tire6);
        polo.Tires.Add(tire7);
        polo.Tires.Add(tire8);

        
        Console.WriteLine(polo.ToString());
        Console.WriteLine("Polo now has:\n");
        foreach (Tire item in polo.Tires)
        {
            Console.WriteLine(item.ToString());
        }


        Car tesla = new Car() { Brand = "Tesla", Model = "SkyNet" };
        tesla.Tires = new List<Tire>();

        Tire tire9 = new Tire() { Manufacturer = "Tesla", Model = "Edison 1", TireSize = "210/55R16" };
        Tire tire10 = new Tire() { Manufacturer = "Tesla", Model = "Edison 1", TireSize = "210/55R16" };
        Tire tire11 = new Tire() { Manufacturer = "Tesla", Model = "Edison 1", TireSize = "210/55R16" };
        Tire tire12= new Tire() { Manufacturer = "Tesla", Model = "Edison 1", TireSize = "210/55R16" };

        tesla.Tires.Add(tire9);
        tesla.Tires.Add(tire10);
        tesla.Tires.Add(tire11);
        tesla.Tires.Add(tire12);

        Console.WriteLine(tesla.ToString());
        
        foreach (Tire item in tesla.Tires)
        {
            Console.WriteLine(item.ToString());
        }

    }

}