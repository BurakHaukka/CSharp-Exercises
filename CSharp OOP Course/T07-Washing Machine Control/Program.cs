using static System.Net.Mime.MediaTypeNames;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

//Your task is to program the operation of the washing machine.Same as the previous task:
//what features and functions would you add to the Washing machine class?
//Design and draw the properties and functions of the Washing machine class as a UML class diagram. 
//Attach the image to the project's repo. 
//Implement the programming of the Washing Machine class and 
//the main program to create an object from the Washing Machine class.
//Adjust the washing machine object with different values ​​from the main program.
//Use Console.WriteLine() print statements to show the user in the main program the state and 
//use of the washing machine object. Implement a few different constructors (at least two different ones)
//in the Washer class and initialize them using the object from the main program.
//Note: the main rule is that the classes do not use the Console class, 
//all interaction for the user will be addressed in the main program. 
//That is, the main program receives information about the properties of the object and the return 
//values ​​of the methods as strings, and displays them on the console
public class WashingMachine 
{
    public int Temperature { get; set; } // 30-95
    public string wProgram { get; set; } //Pre-wash, Eco, Quick
    public string userProgram { get; set; } // Saved user decision for wash program. 
    public bool Power = false; // On-Off

    

    public string machineState {
        get {
            if (Power == true)
                return "Machine is ON";
            else 
            {
                return "OFF";
            }
        }
        set { }
    }
    public string userInteraction(string state, int userTemp, string userProgram) 
    {
        if (state == "y")
        {
            Power = true;
            Temperature = userTemp;
            wProgram = userProgram;

            return $"\n\nWashing Machine is '{machineState}' \n\nTemperature is set to {Temperature} \n\nWash program '{wProgram}' chosen.";
        }
        else if (state == "n") 
        {
            Power = false;
            Temperature = 0;
            wProgram = "No Program Chosen";
            return $"\n\nWashing Machine is '{machineState}' \n\nTemperature is set to {Temperature} \n\nWash program '{wProgram}.\n\nPowering down!";
        }
        return "";
    }
    
   
}
internal class Program
{
    

    private static void Main(string[] args)
    {
        string userProgram = "";
        string state = ""; // user turns ON or OFF
        int userTemp = 0;
       

        WashingMachine HelpingHand = new WashingMachine();

        //OFF state
        HelpingHand.Power = false;
        HelpingHand.Temperature = 0;
        HelpingHand.wProgram = "";

        // Washing machine user input

        Console.WriteLine("Would you like to turn on the machine? (Type 'y' for yes & 'n' for no)");
        state = Console.ReadLine();

        if (state == "y")
        {
            Console.WriteLine("Type in temperature you need (30, 40, 60, 95 C)");
            userTemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What Program would you like to use? (Pre-Wash, Eco, Quick)");
            userProgram = Console.ReadLine();

            Console.WriteLine(HelpingHand.userInteraction(state, userTemp, userProgram));
        }
        else 
        {
            Console.WriteLine(HelpingHand.userInteraction(state, userTemp, userProgram));
        }


        


    }
}