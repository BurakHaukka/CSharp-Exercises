using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace T32
{
    internal class Program
    {
        public delegate void upper(string input);
        public delegate void lower(string input);
        public delegate void title(string input);
        public delegate void reverse(string input);

        public class Operations
        {            

            public void Uppercase(string input) 
            {
                Console.WriteLine(input.ToUpper());
            }
            public void Lowercase(string input)
            {
                Console.WriteLine(input.ToLower());
            }
            public void Title(string input)
            {
                TextInfo TextInfo = new CultureInfo("en-US", false).TextInfo;

                Console.WriteLine(TextInfo.ToTitleCase(input));
            }
            public void Reverse(string input)
            {
                string reversed = string.Empty;

                for (int i = input.Length - 1; i >= 0; i-- ) 
                {
                    reversed += input[i];
                }
               
                
                Console.WriteLine(reversed);
            }
        }
        static void Main(string[] args)
        {
            

            Operations operation = new Operations();

            upper upper_operation = new upper(operation.Uppercase);

            lower lower_operation = new lower(operation.Lowercase);

            title title_operation = new title(operation.Title);

            reverse reverse_operation = new reverse(operation.Reverse);

            int i = 0;          
            while (i != 1) 
            {
                Console.WriteLine("Enter a string to be processed:");
                string input = Console.ReadLine();
                Console.WriteLine("Enter the operations you wany to do\n1) Convert all to capital letters\n2) Convert all to lowercase letters\n3) COnvert to title\n4) Reverse the letters\n0) Terminate the program:");
                string operate = Console.ReadLine();
                                

                char[] operateArray = operate.ToCharArray();

                foreach (char option in operateArray) 
                {
                    switch (option) 
                    {
                        case '1':
                            upper_operation(input);
                            break;
                        case '2':
                            lower_operation(input);
                            break;
                        case '3':
                            title_operation(input);
                            break;
                        case '4':
                            reverse_operation(input);
                            break;
                        case '0':
                            i++;
                            break;
                    }
                }

            }
        }
    }
}
