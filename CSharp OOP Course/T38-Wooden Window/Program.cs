using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T38
{
    internal class Program
    {
        public class Window 
        {
            public double height { get; set; }
            public double width { get; set; }
            public double winCircum { get; set; }
            public double winArea { get; set; }
            public double totalGlass { get; set; }
            

            public double Circumference() 
            {
                double circum = 2 * (height + width);
                winCircum = circum;
                return winCircum;
            }

            public double Area() 
            {
                double area = height * width;
                winArea = area;
                return winArea;
            }

            public double glassArea() 
            {
                totalGlass = 3 * winArea / 10000;
                return totalGlass;
            }

            public string ToString() 
            {
                return $"-----------\nGiven height: {height} (cm)\nGiven width; {width} (cm)\nArea: {winArea} (cm2)\nCircumference: {winCircum} (cm)\nTotal Glass needed (3 layers): {totalGlass} (m2)\n-----------\n";
            }

        }
        static void Main(string[] args)
        {
            

            Console.WriteLine("Give the height of the window:");
            string h = Console.ReadLine();
            double hd = Convert.ToDouble(h);

            Console.WriteLine("Give the width of the window:");
            string w = Console.ReadLine();
            double wd = Convert.ToDouble(w);

            Window window = new Window() { height = hd, width = wd };

            //window.height = hd;
            //window.width = wd;

            window.Circumference();
            window.Area();
            window.glassArea();

            Console.WriteLine(window.ToString());

        }
    }
}
