using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

//Your task is to program the operation of the electric sauna heater. You must be able to turn on the heater
//and besides, both its temperature and the humidity it gives must be able to be adjusted (values ​​are not limited).
//Design the properties and functions of the Kiuas class as a UML class diagram.

//To draw a class diagram, you can
//use the Flow Chart Maker & Online Diagram Software service found on the web
//or, for example, the Violet editor installed on class machines.
//You can install it on your home machine here: Violet UML editor.
//Implement the programming of the Kiuas class and the main program to create an object from the Kiuas class.
//Adjust the stove object with different values ​​in the main program, and show how your stove works with
//Console.WriteLine() print statements in the main program.
//Attach the image of the class diagram to the project's repo as well as the program execution.

//Note 1: Do not use Console.Writeline() or Console.Readline() in classes,
//because their use breaks the reusability and portability of classes to e.g.
//Windows or Web applications; all interaction with the user must be done in the main program
//or in methods belonging to the main program!

//Note2: It is not recommended to use public member variables in C#! So don't use it in the Stove category
//public int Temperature;
//but use the feature
//public int Temperature { get; set; }

internal class Program
{
    class Kiuas 
    {
        public bool State = false; // Kiuas is off at false state. 
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public string stoveState { // getter gets value, setter sets the value but no value in this case
            get 
            {
                if (State == true)
                {
                    return "ON";
                }
                else 
                {
                    return "OFF";
                }
            }
            set { }
        }

        public string StateInteraction(string inter, int interTemp) 
        {
            if (inter == "Yes")
            {
                Temperature = interTemp;
                Humidity = 10;
                State = true;

               return $"\n\nStove status : {stoveState} \n\nTemperature is set to {Temperature} centigrade degrees" +
                    "\n\nHumidity is {Humidity}%. \n\n----------\n\nYou can adjust the humidity through löyly :)\n\n----------\n\n";


            }
            else if (inter == "No")
            {
                Temperature = 20;
                Humidity = 5;
                State = false;
               
                return $"Stove status : {stoveState} \nTemperature {Temperature} centigrade degrees, \nHumidity is {Humidity}%";

            }
            return "";

        }

    }
    private static void Main(string[] args)
    {

        // Electric Stove OFF state
        Kiuas electricStove = new Kiuas();
        electricStove.Temperature = 0;
        electricStove.Humidity = 0;
        electricStove.State = false;

        // Electric Stove usage
        string inter = "";
        string UserinterTemp = "";
        int interTemp = 0;

        Console.WriteLine("Would you like to turn on the wood stove interface? ( type Yes or No) : ");
        inter = Console.ReadLine();

        Console.WriteLine("What temperature you want to have? : ");
        UserinterTemp = Console.ReadLine();
        interTemp = Convert.ToInt32(UserinterTemp);
        

        
        string afterInteraction = ""; 
        afterInteraction = electricStove.StateInteraction(inter, interTemp); // State of the Stove is assigned
        Console.WriteLine(afterInteraction); // State of the Stove is printed







    }
}