using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T29
{
    public interface ITransaction 
    {
        string ShowTransaction(); //returns how the payment was made and amount of payment
        float Money { get; set; } //showsamount paid 
    }
    public class PaidWithCash : ITransaction
    {
        public float Money { get; set; }
        int counter = 0;
        DateTime date = DateTime.Now;
        float total = 0;
        public List<PaidWithCash> CashPaid { get; set; }

       public int Counter() 
       {
           return counter++;
       }
        
      //public float ShowCash() // Shows total cash in register
      // {
      //      total += Money;
            
      //      return total;
      // }

        public string ToString()
        {
            return $"Total Cash Payment: {Money} Euros in register";
        }

        public string ShowTransaction()
        {
            return $"Cash payment to register.\nDate: {date}.\nPaid Amount: {Money}\n"; 
        }
    }

    public class PaidWithCard : ITransaction
    {
        public float Money { get; set; }
        int counter = 0;
        DateTime date = DateTime.Now;
        float total = 0;

        public int Counter()
        {
            return counter++;
        }

        public float ShowTotal(float Money) // show how much paid to account
        {
            total += Money;
            return Money;
        }

        public string ToString() 
        {
            return $"\nTotal Card Payment: {total} Euros in register\n";
        }

        public string ShowTransaction()
        {
            return $"Card payment to account.\nDate: {date}.\nPaid Amount: {Money}\n";
        }

    }
    
    internal class Program
    {


        static void Main(string[] args)
        {
            List<float> Cash = new List<float>();
            List<float> Card = new List<float>();
            int counter = 0;
            float cashTotal = 0;
            float cardTotal = 0;
            float dayTotal = 0;

            // Cash Payments
            Console.WriteLine("\n----Cash Payments----\n");

            PaidWithCash CashPayment = new PaidWithCash() { Money = 20.25F };
            PaidWithCash CashPayment1 = new PaidWithCash() { Money = 11.25F };
            PaidWithCash CashPayment2 = new PaidWithCash() { Money = 17.25F };
            PaidWithCash CashPayment3 = new PaidWithCash() { Money = 210.33F };
            Cash.Add(CashPayment.Money);
            Cash.Add(CashPayment1.Money);
            Cash.Add(CashPayment2.Money);
            Cash.Add(CashPayment3.Money);

            Console.WriteLine(CashPayment.ShowTransaction());
            Console.WriteLine(CashPayment1.ShowTransaction());
            Console.WriteLine(CashPayment2.ShowTransaction());
            Console.WriteLine(CashPayment3.ShowTransaction());


            foreach (float payment in Cash)
            {
                cashTotal += payment;
                counter++;
            }

            Console.WriteLine($"\nTotal Cash in register: {cashTotal}");




            // Card Payments
            Console.WriteLine("\n----Card Payments----\n");

            PaidWithCard paymentC = new PaidWithCard() { Money = 11.33F };
            PaidWithCard paymentC1 = new PaidWithCard() { Money = 231.23F };
            PaidWithCard paymentC2 = new PaidWithCard() { Money = 35.33F };
            PaidWithCard paymentC3 = new PaidWithCard() { Money = 3.6F };
            Card.Add(paymentC.Money);
            Card.Add(paymentC1.Money);
            Card.Add(paymentC2.Money);
            Card.Add(paymentC3.Money);

            Console.WriteLine(paymentC.ShowTransaction());
            Console.WriteLine(paymentC1.ShowTransaction());
            Console.WriteLine(paymentC2.ShowTransaction());
            Console.WriteLine(paymentC3.ShowTransaction());

            foreach (float payment in Card)
            {
                cardTotal += payment;
                counter++;
            }
            Console.WriteLine($"\nTotal Cash in register: {cardTotal}\n");

            // Total money in Register

            dayTotal = cashTotal + cardTotal;

            Console.WriteLine($"Today's Total Balance: {dayTotal}\nServed customers: {counter}\n");

        }

    }
}
