namespace MyFishRegister
{
    public class Fisherman : Fish
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public static void PrintFishRegister(List<Fish> fishList, Fisherman fisherman) //, FishingPlace fishingPlace)
        {
            Console.WriteLine("----------\nFisherman: " + fisherman.Name + ", Phone: " + fisherman.PhoneNumber);
            Console.WriteLine("Fish Register: \n----------");

            //sort the fish list by weight in descending order
            fishList.Sort((x, y) => y.Weight.CompareTo(x.Weight));

  
            foreach (Fish fish in fishList)
            {
                Console.WriteLine($"Spot: {fish.Spot}\nLocation: {fish.Location}\nSpecies: {fish.Species}\nLength: {fish.Length} cm\nWeight: {fish.Weight} kg\n\n");
            }
        }
    }

    public class Fish : FishingPlace
    {
        public string Species { get; set; }
        public int Length { get; set; }
        public double Weight { get; set; }
    }

    public class FishingPlace
    {
        public string Spot { get; set; }
        public string Location { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //create a list to store the fish information
            List<Fish> fishList = new List<Fish>();

            //create a fisherman object and set its properties
            Fisherman fisherman = new Fisherman();
            fisherman.Name = "Burak Dogan";
            fisherman.PhoneNumber = "1234567890";

       
            Fish fish1 = new Fish();
            fish1.Species = "Salmon";
            fish1.Length = 25;
            fish1.Weight = 1.2;
            fish1.Spot = "Tuomiojärvi";
            fish1.Location = "Jyväskylä";


            Fish fish2 = new Fish();
            fish2.Species = "Pike";
            fish2.Length = 40;
            fish2.Weight = 2;
            fish2.Spot = "Tuomio Järvi";
            fish2.Location = "Jyväskylä";

            Fish fish3 = new Fish();
            fish3.Species = "Blue Fin Tuna";
            fish3.Length = 200;
            fish3.Weight = 15;
            fish3.Spot = "Pacific Ocean";
            fish3.Location = "Hawaii";

            fishList.Add(fish1);
            fishList.Add(fish2);
            fishList.Add(fish3);

           
            Fisherman.PrintFishRegister(fishList, fisherman);

            List<Fish> fishList2 = new List<Fish>();

            //create a fisherman object and set its properties
            Fisherman fisherman2 = new Fisherman();
            fisherman2.Name = "Teppo Kalamies";
            fisherman2.PhoneNumber = "24238492";


            Fish fish4 = new Fish();
            fish4.Species = "Hauka";
            fish4.Length = 25;
            fish4.Weight = 1.2;
            fish4.Spot = "Jyväsjärvi";
            fish4.Location = "Jyväskylä";


            Fish fish5 = new Fish();
            fish5.Species = "Salmon";
            fish5.Length = 40;
            fish5.Weight = 2;
            fish5.Spot = "TuomioJärvi";
            fish5.Location = "Jyväskylä";

            Fish fish6 = new Fish();
            fish6.Species = "Roach";
            fish6.Length = 10;
            fish6.Weight = 0.2;
            fish6.Spot = "Palokkajärvi";
            fish6.Location = "Jyväskylä";

            fishList2.Add(fish4);
            fishList2.Add(fish5);
            fishList2.Add(fish6);

            Fisherman.PrintFishRegister(fishList2, fisherman2);





        }
    }
}