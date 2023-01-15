internal class Program
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nModel: {Model}\nYear: {Year}\nColor: {Color}\n";
        }
    }

    public class Bicycle : Vehicle
    {
        public int gear;
        public string GearBrand { get; set; }
        public string GearType { get; set; }
        public string BicycleType { get; set; }

        public string DecideGearType(int gear)
        {
            if (gear == 1)
            {
                GearType = "Single Gear";
                return GearType;
            }
            else
            {
                GearType = "Casette";
                return GearType;
            }
        }
        //public int Gear
        //{
        //    get { return gear; }
        //    set
        //    {
        //        if (gear == 1)
        //        {
        //            Gear = 1;
        //            GearType = "Single Gear";
        //        }
        //        else
        //        {
        //            Gear = gear;
        //            GearType = "Casette";

        //        }
        //    }
        //}

        public override string ToString()
        {
            return base.ToString() + $"Bicycle Type: {BicycleType}\nGear: {gear}\nGear Brand: {GearBrand}\nGear Type: {GearType}\n";
        }
    }

    public class Boat : Vehicle
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public virtual string ToString()
        {
            return base.ToString() + $"Boat Type: {BoatType}\nSeat Count: {SeatCount}\n";
        }
    }


    private static void Main(string[] args)
    {
        Bicycle White = new Bicycle() { Name = "White", Model = "Fat Lite", Year = 2019, Color = "Orange", BicycleType = "Fat Bike", GearBrand = "Shimano Deore", gear = 10 };
        Bicycle Bottechia = new Bicycle() { Name = "Bottechia", Model = "V9", Year = 2019, Color = "Red-Black", BicycleType = "Mountain", GearBrand = "Sram Eagle", gear = 10 };
        Bicycle Jopo = new Bicycle() { Name = "Jopo", Model = "City 5", Year = 2000, Color = "Purple", BicycleType = "City", GearBrand = "SunFish", gear = 1 };

        White.DecideGearType(White.gear);
        Bottechia.DecideGearType(Bottechia.gear);
        Jopo.DecideGearType(Jopo.gear);

        Console.WriteLine(White.ToString());
        Console.WriteLine(Bottechia.ToString());
        Console.WriteLine(Jopo.ToString());




        Boat Zodiac = new Boat() { Name = "Kaptan", Model = "Lake 100", Year = 2000, Color = "Gray", SeatCount = 5, BoatType = "Inflatable" };
        Boat Pirat = new Boat() { Name = "Pirat", Model = "-", Year = 1990, Color = "White-Brown", SeatCount = 2, BoatType = "Sail-Competition" };

        Console.WriteLine(Zodiac.ToString());
        Console.WriteLine(Pirat.ToString());
    }
}