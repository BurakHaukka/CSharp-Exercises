using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T37
{
    internal class Program
    {
        public class Dice 
        {


            public void Roll(int rolls) 
            {
                Random random = new Random();

                List<int> Rolls = new List<int>();

                List<int> rolls_1 = new List<int>();
                List<int> rolls_2 = new List<int>();
                List<int> rolls_3 = new List<int>();
                List<int> rolls_4 = new List<int>();
                List<int> rolls_5 = new List<int>();
                List<int> rolls_6 = new List<int>();



                if (rolls == 1)
                {
                    int roll = random.Next(1, 7);

                    Console.WriteLine($"Test roll is : {roll}");


                }
                if (rolls > 1) 
                {
                    int i = 1;
                    do
                    {
                        int roll = random.Next(1, 7);
                        Rolls.Add(roll);
                        
                        switch (roll) 
                        {
                            case 1:
                                rolls_1.Add(roll);
                                break;
                            case 2:
                                rolls_2.Add(roll);
                                break;
                            case 3:
                                rolls_3.Add(roll);
                                break;
                            case 4:
                                rolls_4.Add(roll);
                                break;
                            case 5:
                                rolls_5.Add(roll);
                                break;
                            case 6:
                                rolls_6.Add(roll);
                                break;
                        }

                        i++;
                    } while (i <= rolls);

                    Console.WriteLine($"Rolled 1 {rolls_1.Count} x times");
                    Console.WriteLine($"Rolled 2 {rolls_2.Count} x times");
                    Console.WriteLine($"Rolled 3 {rolls_3.Count} x times");
                    Console.WriteLine($"Rolled 4 {rolls_4.Count} x times");
                    Console.WriteLine($"Rolled 5 {rolls_5.Count} x times");
                    Console.WriteLine($"Rolled 6 {rolls_6.Count} x times");

                    int sum = Rolls.Sum();
                    float sum_float = sum;
                    float rolls_float = rolls;
                    Console.WriteLine($"Average value of rolls : {sum_float / rolls_float}");

                }
                                   
                    

            }
        }
        static void Main(string[] args)
        {
            Dice dice = new Dice();

            //Console.WriteLine("Input 1 for a test roll or input how many times you want to roll the dice.");
            //string UserRoll = Console.ReadLine();
            int i = 0;
            while (i == 0) 
            {
                Console.WriteLine("Input 1 for a test roll or input how many times you want to roll the dice. Press Enter to stop.");
                string UserRoll = Console.ReadLine();
                if (UserRoll == "1")
                {
                    dice.Roll(1);
                   
                }
                else if (UserRoll != "1" && !String.IsNullOrEmpty(UserRoll))
                {
                    int IntUserRoll = Convert.ToInt32(UserRoll);
                    dice.Roll(IntUserRoll);
                }
                else if (String.IsNullOrEmpty(UserRoll))
                {
                    i++;
                    Console.WriteLine("Bye !");
                }
            }
            
            
            
        }
    }
}
