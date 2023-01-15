/*
Make a method to calculate the cost of a certain trip.
In the main program the user is asked for the distance driven,
check that the given input is a number. After that, the main program calls 
the method sending the number of kilometers driven as a parameter. 
The method draws randomly consumption between 6 - 9 liters/100km. 
The price of fuel is estimated to be between €2.5/litre.
The method returns the amount of gasoline consumed and the amount of money spent on gasoline,
the main program shows them to the user.
*/
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        const float price = 2.5F;
        string distInput;
        int dist;
        float consumed;
        float cost;
        Random consumpti = new Random();
        Console.WriteLine(consumpti);

        int consumption = consumpti.Next(6, 10);
        Console.WriteLine(consumption);

        Console.WriteLine("Enter the distance driven in kilometers: ");
        if (int.TryParse(distInput = Console.ReadLine(), out dist))
            Consumed(dist);
        else
            Console.WriteLine("Not a number. Restart and try again.");

        void Consumed(int dist)
        {
            //Take distance from user.
            // Randomly decide consumption
            // return cost and consumed fuel to user
            consumed = dist * consumption / 100;
            cost = consumed * price;

            Console.WriteLine($"Your trip has consumed {consumed} liters of fuel. \nYour consumption was {consumption} l/km and costed {cost}");
        }


    }
}