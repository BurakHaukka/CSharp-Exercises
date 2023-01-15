using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T23
{
    internal class Program
    {
        public class Checkout 
        {
            public string customer { get; set; }

            public Queue<string> queue = new Queue<string>();


            public void GoToQueue(string customer) 
            {
                queue.Enqueue(customer);
            }

            public string ExitQueue() 
            {
                return queue.Dequeue();
            }

            public int Length() 
            {
                return queue.Count; 
            }

        }
        static void Main(string[] args)
        {
           string customer;
           Checkout checkout = new Checkout();
           int i = 0;
            do  
            {

                Console.WriteLine("----------Queue for Checkout----------\n");
                Console.WriteLine("Enter the name of the Customer (press enter with empty input to stop): ");
                customer = Console.ReadLine();

                if (customer != "")
                {
                    checkout.GoToQueue(customer);
                    Console.WriteLine(checkout.queue.Count);
                }
                else 
                {
                    i++;
                    
                }
                

            } while (i < 1);

            Console.WriteLine($"The queue has {checkout.queue.Count}\n");

            foreach (string item in checkout.queue)
            {
                Console.WriteLine(item + "\n");
               
            }


            while (checkout.queue.Count > 0) 
            {
                string deqCustomer = checkout.ExitQueue();
                Console.WriteLine($"Attending to customer {deqCustomer}\n------");
            }
        }
    }
}
