using System.Diagnostics.Contracts;

internal class Program
{
    public abstract class Mammal 
    {
        public int Age { get; set; }
        public abstract string Move();  
    }

    public class Human : Mammal 
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public void Grow() 
        {
            Age++;
        }
        public override string Move()
        {
            return $"\nMoving\n";
        }
    }

    public class Baby : Human 
    {
        public string Diaper { get; set; }
        public override string Move()
        {
            return $"\nCrawling\n";
        }
        public override string ToString()
        {
            return $"\n----\nBaby\n----\nName: {Name}\nAge: {Age}\nHeight: {Height}\nWeight: {Weight}\nDiaper: {Diaper}";
        }
    }

    public class Adult : Human 
    {
        public string Auto { get; set; }
        public override string Move() 
        {
            return $"\nWalking\n";
        }

        public override string ToString()
        {
            return $"\n----\nAdult\n----\nName: {Name}\nAge: {Age}\nHeight: {Height}\nWeight: {Weight}\nCar: {Auto}";
        }
    }
    private static void Main(string[] args)
    {
        Adult Burak = new Adult() { Name = "Burak", Age = 35, Weight = 86, Height = 177, Auto = "WV Polo" };
        Console.WriteLine(Burak.ToString());
        Console.WriteLine(Burak.Move());
        Burak.Grow();
        Console.WriteLine(Burak.ToString());

        Adult Kubra = new Adult() { Name = "Kubra", Age = 33, Weight = 60, Height = 175, Auto = "Tofas" };
        Console.WriteLine(Kubra.ToString());
        Console.WriteLine(Kubra.Move());
        Kubra.Grow();
        Console.WriteLine(Kubra.ToString());

        Baby Nameless = new Baby() { Name = "Nameless", Age = 0, Weight = 2, Height = 50, Diaper = "Yes" };
        Console.WriteLine(Nameless.ToString());
        Console.WriteLine(Nameless.Move());
        Nameless.Grow();
        Console.WriteLine(Nameless.ToString());
    }
}