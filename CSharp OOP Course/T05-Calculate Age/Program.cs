//Make a program that asks the user for people's names and their year of birth. Name and Year of Birth are separated by a comma.
//Entering names is finished by entering an empty entry.
//After this, the program tells how many names were given and displays them in order of age from youngest to oldest.



// Weakness of this program is that it will not allow duplicate people. Meaning you can not have two people with same name.
// Because name is used as key when storing information in the dictionary.
using System;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        string inputParse = "";
        string[] storeParsedInput;
        Dictionary<string, Int32> NamesYears = new Dictionary<string, Int32>();
        int thisYear = System.DateTime.Now.Year;


        Console.WriteLine("Please enter a name and birthyear separated by comma and space (Ex: name, year)");


        do
        {
            if (!String.IsNullOrEmpty(inputParse))
            {
                storeParsedInput = inputParse.Split(", ");

                string name = storeParsedInput[0];
                string year = storeParsedInput[1];
                NamesYears.Add(name, Convert.ToInt32(year));

            }
            inputParse = Console.ReadLine();

            var orderedNamesYears = NamesYears.OrderByDescending(NamesYears => NamesYears.Value).ToDictionary(NamesYears => NamesYears.Key, NamesYears => NamesYears.Value);
            // Because I am ordering before calculating the age, OrderByDescending, because YEAR IS SMALLER WHEN PEOPLE ARE OLDER !!! Mental note !
            if (String.IsNullOrEmpty(inputParse))
            {
                Console.WriteLine($"There are {NamesYears.Count()} people.");

                for (int i = 0; i < orderedNamesYears.Count; i++)
                {
                    Console.WriteLine($"{orderedNamesYears.ElementAt(i).Key} is {thisYear - orderedNamesYears.ElementAt(i).Value} years old.");

                }

            }

        } while (!String.IsNullOrEmpty(inputParse));

    }
   
}

 

