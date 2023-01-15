public class Elevator 
{
    public const int MaxFloor = 5;
    public const int MinFLoor = 1;
    public int Floor = 1;
    public int inputFloor = 1;
    public bool state;

    public bool DidItGo(int inputFloor) 
    {
        if (MinFLoor <= inputFloor && inputFloor <= MaxFloor)
        {
            state = true;
            Floor = inputFloor;
            return state;
        } 
        else
        {
            state = false;
            Floor = 1;
            return state;
        }
    }

    //public int GoTo(bool state, int inputFloor)  
    //{
    //    if (state == true)
    //    {
    //        Floor = inputFloor;

    //        return Floor;
    //    }
    //    else if (state == false)
    //    {
    //        Floor = 1;
    //    }    return Floor;
        
    //}

    public virtual string ToString(bool state, int Floor) 
    {
        if (state == true)
        {
            return $"\nElevator is at {Floor}.\n";
        }
        else 
        {
            return $"\n!-!-!-!-!\nThere is no such floor.\n!-!-!-!-!\n";
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Elevator JAMK = new Elevator { Floor = 1 };

       
        string input;
        //Console.WriteLine("Give a floor to go 1-5. Press Enter to exit : ");
        //input = Console.ReadLine();

        do
        {

            Console.WriteLine($"Give a floor to go 1-5. Press Enter to exit :");
            input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input))
            {
                JAMK.inputFloor = Int16.Parse(input);
                //JAMK.GoTo(JAMK.state, JAMK.inputFloor);
                JAMK.DidItGo(JAMK.inputFloor);
                
                //Console.WriteLine(JAMK.GoTo(JAMK.state, JAMK.inputFloor));
                Console.WriteLine(JAMK.ToString(JAMK.state, JAMK.Floor));
            }
            else
            {
                Console.WriteLine("Please leave the elevator.");
            }


        } while (!String.IsNullOrEmpty(input));
    }
 
}
