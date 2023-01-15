public class Amplifier
{
    
    public int intInput { get; set; }
    private int volume;
    
    public int Volume
    { get { return volume; } }


    public string SetVolume(int intInput) 
    {
        if (intInput < 0)
        {
            volume = 0;
            return $"\nVolume is too low. Volume set to {Volume}";
        }
        else if (intInput > 100)
        {
            volume = 100;
            return $"\nVolume is too high. Volume is set to {Volume}";
        }
        else 
        {
            volume = intInput;
            return $"Volume is set to {Volume}";
        }
    }


        
}
   

internal class Program
{
    private static void Main(string[] args)
    {
        Amplifier Fisher = new Amplifier();
        int intInput;
        string input;

        do
        {
            Console.WriteLine("\nEnter the volume you want to set. Press Enter with blank input to exit.");
            input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input))
            {
                intInput = Int32.Parse(input);
                Console.WriteLine(Fisher.SetVolume(intInput));
            }
            else
            {
                Console.WriteLine("Bye Bye ! !");
            }
            

            

        } while (!String.IsNullOrEmpty(input));        
    }
}