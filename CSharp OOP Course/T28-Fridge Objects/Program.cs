using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace T28
{
    internal class Program
    {
        public class Refrigerator 
        {
            private List <Frozen> frozen = new List <Frozen>();
            private List <Dairy> dairy = new List <Dairy>();
            private List <Veggie> veggie = new List <Veggie>();
            private List <Fruit> fruit = new List <Fruit>();

            public List <Frozen> Frozens { get { return frozen; } }
            public List <Dairy> Dairy { get { return dairy; } }
            public List <Veggie> Veggies { get { return veggie; } }
            public List <Fruit> Fruits { get { return fruit; } }

        }

        public class Fruit 
        {
            public string Name { get; set; }
            public int Amount { get; set; }

            public string ToString() 
            {
                return $"Fruit: {Name} x{Amount}";
            }
        }

        public class Veggie
        {
            public string Name { get; set; }
            public int Amount { get; set; }

            public string ToString()
            {
                return $"Veggie: {Name} x{Amount}";
            }
        }

        public class Dairy
        {
            public string Name { get; set; }
            public int Amount { get; set; }

            public string ToString()
            {
                return $"Dairy: {Name} x{Amount}";
            }
        }

        public class Frozen
        {
            public string Name { get; set; }
            public int Amount { get; set; }

            public string ToString()
            {
                return $"Frozen: {Name} x{Amount}";
            }
        }

        static void Main(string[] args)
        {
            Refrigerator fridge = new Refrigerator();

            Fruit apple = new Fruit() { Name = "Apple", Amount = 10 };
            Fruit avocado = new Fruit() { Name = "Avocado", Amount = 3 };
            Fruit mango = new Fruit() { Name = "Mango", Amount = 1 };
            Fruit orange = new Fruit() { Name = "Orange", Amount = 3 };

            fridge.Fruits.Add(apple);
            fridge.Fruits.Add(avocado);
            fridge.Fruits.Add(mango);
            fridge.Fruits.Add(orange);

            Veggie veg1 = new Veggie() { Name = "Lettuce", Amount = 2 };
            Veggie veg2 = new Veggie() { Name = "Carrot", Amount = 10 };
            Veggie veg3 = new Veggie() { Name = "Cabbage", Amount = 1 };

            fridge.Veggies.Add(veg1);
            fridge.Veggies.Add(veg2);
            fridge.Veggies.Add(veg3);

            Dairy dairy1 = new Dairy() { Name = "Milk", Amount = 1 };
            Dairy dairy2 = new Dairy() { Name = "Butter", Amount = 1 };
            Dairy dairy3 = new Dairy() { Name = "Cream", Amount = 2 };

            fridge.Dairy.Add(dairy1);
            fridge.Dairy.Add(dairy2);
            fridge.Dairy.Add(dairy3);


            Frozen froz1 = new Frozen() { Name = "Bagged Brussel Sprouts", Amount = 1 };
            Frozen froz2 = new Frozen() { Name = "Bagged Cauliflower", Amount = 1 };
            Frozen froz3 = new Frozen() { Name = "Bagged Peas", Amount = 1 };

            fridge.Frozens.Add(froz1);
            fridge.Frozens.Add(froz2);
            fridge.Frozens.Add(froz3);

            Console.WriteLine("--- Listing Fridge Items ---\n");
            foreach (Fruit item in fridge.Fruits)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n---  ---\n");
            foreach (Veggie item in fridge.Veggies)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n---  ---\n");
            foreach (Dairy item in fridge.Dairy)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n---  ---\n");
            foreach (Frozen item in fridge.Frozens)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n---  ---\n");
        }
    }
}
