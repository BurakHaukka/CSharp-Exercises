using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T25
{
    internal class Program
    {
        public class Vehicle
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
                return $"Vehicle: {Model} - {Brand} has a set of {TireNumber} tires installed.\n";
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
            Vehicle polo = new Vehicle() { Brand = "VW", Model = "Polo" };
            polo.Tires = new List<Tire>();

            Tire tire1 = new Tire() { Manufacturer = "Prelli", Model = "Model 1", TireSize = "205/45R16" };
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
            Console.WriteLine("\n");
            // Changing tire of the car

            polo.Tires.Clear();

            Tire tire5 = new Tire() { Manufacturer = "Lassa", Model = "ICEWAYS 2", TireSize = "225/45R17 91T" };
            Tire tire6 = new Tire() { Manufacturer = "Lassa", Model = "ICEWAYS 2", TireSize = "225/45R17 91T" };
            Tire tire7 = new Tire() { Manufacturer = "Lassa", Model = "ICEWAYS 2", TireSize = "225/45R17 91T" };
            Tire tire8 = new Tire() { Manufacturer = "Lassa", Model = "ICEWAYS 2", TireSize = "225/45R17 91T" };

            polo.Tires.Add(tire5);
            polo.Tires.Add(tire6);
            polo.Tires.Add(tire7);
            polo.Tires.Add(tire8);

            Console.WriteLine("New tire set is:\n");
            Console.WriteLine(polo.ToString());

            foreach (Tire item in polo.Tires)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n");
            /// End of Car ///


            Vehicle ducati = new Vehicle() { Brand = "Ducati", Model = "Scrambler Desert Sled" };
            ducati.Tires = new List<Tire>();

            Tire tire9 = new Tire() { Manufacturer = "Kenda", Model = "K760 TrakMaster II", TireSize = "130/90R17" };
            Tire tire10 = new Tire() { Manufacturer = "Kenda", Model = "K760 TrakMaster II", TireSize = "130/90R17" };
            

            ducati.Tires.Add(tire9);
            ducati.Tires.Add(tire10);

            Console.WriteLine(ducati.ToString());

            foreach (Tire item in ducati.Tires)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n");

            // Changing tire of the motorbike

            ducati.Tires.Clear();

            Tire tire11 = new Tire() { Manufacturer = "Kenda", Model = "K774 Ibex", TireSize = "130/90R17" };
            Tire tire12 = new Tire() { Manufacturer = "Kenda", Model = "K774 Ibex", TireSize = "130/90R17" };


            ducati.Tires.Add(tire11);
            ducati.Tires.Add(tire12);

            Console.WriteLine("New tire set is:\n");
            Console.WriteLine(ducati.ToString());

            foreach (Tire item in ducati.Tires)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n");
            /// End of motorbike ///

        }
    }
}
