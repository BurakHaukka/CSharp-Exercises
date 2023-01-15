using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T34
{
    public class ArrayCalcs
    {
        public static string Sum(double[] array)
        {
            double Sum = array.Sum();

            return $"Sum = {Sum}";
        }

        public static string Average(double[] array)
        {
            double Ave = array.Sum() / array.Length;

            return $"Average = {Math.Round(Ave, 2)}";
        }

        public static string Max(double[] array)
        {
            double Max = array.Max();

            return $"Max = {Max}";
        }

        public static string Min(double[] array)
        {
            double Min = array.Min();

            return $"Min = {Min}";
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            new ArrayCalcs();
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

            Console.WriteLine(ArrayCalcs.Sum(array));
            Console.WriteLine(ArrayCalcs.Average(array));
            Console.WriteLine(ArrayCalcs.Max(array));
            Console.WriteLine(ArrayCalcs.Min(array));
        }
    }
}
