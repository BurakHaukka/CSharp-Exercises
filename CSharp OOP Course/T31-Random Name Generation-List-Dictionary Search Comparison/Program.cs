using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace T31
{
    public class Person
    {
        public string Name { get; set; }
        public string SName { get; set; }
        //////public string randomName { get; set; }



        //Length as parameter is important because first and lastnames have different set lengths
        public static string RandomNameGen(int char_len)
        {
            Random rand = new Random();
            string randomName = "";
            int RndNumber;
            char RndLetter;

            for (int i = 0; i < char_len; i++)
            {
                // Using ASCII capital characters, range refers to capital letter ASCII code
                //Its random, since we need randomized letters in the names
                RndNumber = rand.Next(65, 91);

                //Converting number to char
                RndLetter = Convert.ToChar(RndNumber);

                //Building the randomized name
                randomName += RndLetter;
            }

            return randomName;
        }

        // This is a methos to build and this can return list.
        // Size is necessary because we can test different size 
        public static List<Person> nameList(int size)
        {
            List<Person> personList = new List<Person>();

            // Loop creates person firstname and lastname
            for (int i = 0; i < size; i++)
            {
                // Calling name generator method to create desired length names and surnames
                string name = RandomNameGen(4);
                string sname = RandomNameGen(10);

                //Create new person
                Person person = new Person(name, sname);
                personList.Add(person);


            }
            return personList;
        }

        // Creating Dictionary, just like List, it returns Dictionary
        public static Dictionary<string, Person> nameDictionary(int size)
        {
            Dictionary<string, Person> personDict = new Dictionary<string, Person>();


            //Because dictionary keys have to be uniqe, can not use for loop.
            // I want loop to end after reaching the max size. With for loop,
            // if same name is generated, loop counter still increases and it doesnt reach desired size.
            while (personDict.Count < size)
            {
                string name = RandomNameGen(4);
                string sname = RandomNameGen(10);

                //Checking if same key-name exists and adding if same key doesnt exist
                if (!personDict.ContainsKey(name))
                {
                    Person person = new Person(name, sname);
                    personDict.Add(name, person);
                }

            }
            return personDict;
        }

        public Person(string name, string sname)
        {
            Name = name;
            SName = sname;
        }

    }





    internal class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch can be used to mease processes§ 
            var listBuildTime = new System.Diagnostics.Stopwatch();

            // Measuring List creation
            listBuildTime.Start();
            List<Person> total_List = Person.nameList(10000);
            listBuildTime.Stop();

            //List information
            Console.WriteLine("---List information---");
            Console.WriteLine($"Measured time for generating list: {listBuildTime.ElapsedMilliseconds} ms");
            Console.WriteLine($"Persons: {total_List.Count}\n");



            // 1000 Random persons will be created to be used in search
            var searchTimeLambda = new System.Diagnostics.Stopwatch();

            List<Person> namesToSearch = Person.nameList(1000);

            List<Person> foundNames = new List<Person>();


            // Search Time starts
            searchTimeLambda.Start();

            // List check with Lambda

            foreach (Person personToSearch in namesToSearch)
            {
                foreach (Person person in total_List.FindAll(person => person.Name.StartsWith(personToSearch.Name)))
                {
                    foundNames.Add(personToSearch);
                    Console.WriteLine($"Searched Name {personToSearch.Name}... => Person found || Name :{person.Name} || Last Name: {person.SName}");
                }
            }
                    
            
            // List loop with if-check
            //Search Time ends
            searchTimeLambda.Stop();

            var searchTimeList = new System.Diagnostics.Stopwatch();

            searchTimeList.Start();

            foreach (Person searchPerson in total_List)
            {
                foreach (Person person in namesToSearch)
                {
                    if (person.Name.Equals(searchPerson.Name))
                    {

                        foundNames.Add(searchPerson);
                    }
                }
            }
            searchTimeList.Stop();

            

            Console.WriteLine($"\n\nPersons tried to find {namesToSearch.Count}");
            Console.WriteLine($"\nPersons found by both List tests {foundNames.Count}\n");

            // Starting Dictionary build

            var dictinaryBuildTime = new System.Diagnostics.Stopwatch();

            dictinaryBuildTime.Start();
            Dictionary<string, Person> personsDict = Person.nameDictionary(10000);
            dictinaryBuildTime.Stop();

            Console.WriteLine("---Dictionary information---");
            Console.WriteLine($"Measured time for generating dictionary: {dictinaryBuildTime.ElapsedMilliseconds} ms");
            Console.WriteLine($"Persons: {personsDict.Count}\n");

            // 1000 random persons for dictionary test
            var searchTimeDictionary = new System.Diagnostics.Stopwatch();
            var searchTimeDictionaryLambda = new System.Diagnostics.Stopwatch();

            Dictionary<string, Person> namesToSearchDict = Person.nameDictionary(1000);

            Dictionary<string, Person> foundNamesDict = new Dictionary<string, Person>();
            Dictionary<string, Person> foundNamesDict2 = new Dictionary<string, Person>();

            searchTimeDictionary.Start();
            foreach (var person in personsDict) 
            {
                foreach (var personToSearch in namesToSearchDict) 
                {
                    if (personToSearch.Key == person.Key) 
                    {
                        foundNamesDict.Add(person.Key, person.Value);
                    }
                }
            }

            foreach (var foundPerson in foundNamesDict) 
            {
                Console.WriteLine($"Searched Name {foundPerson.Key}... => Person found || Name :{foundPerson.Value.Name} || Last Name: {foundPerson.Value.SName}");
            }
            searchTimeDictionary.Stop();

            Console.WriteLine("------Lambda Test------");

            searchTimeDictionaryLambda.Start();
            foreach (var personToSearch in namesToSearchDict)
            {
                foreach (var person in personsDict.Keys.Where(person => person.StartsWith(personToSearch.Key)))
                {
                    foundNamesDict2.Add(personToSearch.Key, personToSearch.Value);                    
                }
            }
            searchTimeDictionaryLambda.Stop();

            foreach (var person in foundNamesDict2) 
            {
                Console.WriteLine($"People found => Name: {person.Key} Last Name: {person.Value.SName}");
            }

            Console.WriteLine($"\n\nPersons tried to find {namesToSearchDict.Count}");
            Console.WriteLine($"\nPersons found Dictionary test {foundNamesDict.Count}");
            Console.WriteLine($"\nPersons found by Dictionary-Lambda test {foundNamesDict.Count}\n");

            Console.WriteLine("-----Time Measurements-----");
            Console.WriteLine($"\nElapsed Time for List nested foreach loop with Lambda: {searchTimeLambda.ElapsedMilliseconds} ms\n");
            Console.WriteLine($"Elapsed Time for List nested foreach loop with if-check: {searchTimeList.ElapsedMilliseconds} ms\n");
            Console.WriteLine($"\nElapsed Time for Dictionary nested foreach loop with Lambda: {searchTimeDictionaryLambda.ElapsedMilliseconds} ms\n");
            Console.WriteLine($"Elapsed Time for Dictionary nested foreach loop with if-check: {searchTimeDictionary.ElapsedMilliseconds} ms\n");
            
        }
    }
    
}
