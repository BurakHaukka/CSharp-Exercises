using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace T40
{
    public class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string SID { get; set; }
        public string Group { get; set; }

        public Student(string fname, string lname, string sid, string group)
        {
            // Constructor for student
            FName = fname;
            LName = lname;
            SID = sid;
            Group = group;
        }
        public override string ToString()
        {
            return $"Name: {FName} -- Lastname: {LName} -- SID: {SID} -- Group: {Group}";
        }
    }
    public class Register : Student
    {
        public List<Student> Students = new();

        
        public Register(string fname, string lname, string sid, string group) : base(fname, lname, sid, group)
        {
            // This is suggested by Intellisense : base(parameter, parameter ..) means Register uses parameters of Student class
        }

        public void AddStudents(string fname, string lname, string group)
        {

            FName = fname;
            LName = lname;
            Group = group;
            SID = SIDGenerator();

            Students.Add(new Student(FName, LName, SID, Group));
        }
        public void AddStudent()
        {
            TextInfo TextInfo = new CultureInfo("en-US", false).TextInfo;

            
            Console.WriteLine("---- New Student ----");
            Console.WriteLine("New student's name: ");
            FName = Console.ReadLine();

            Console.WriteLine("New student's lastname:");
            LName = Console.ReadLine();

            Console.WriteLine("New student's group ID");
            Group = Console.ReadLine();

            SID = SIDGenerator();
            Students.Add(new Student(TextInfo.ToTitleCase(FName), TextInfo.ToTitleCase(LName), SID, Group.ToUpper()));
        }

        public string SIDGenerator()
        {
            // Generates student numbers according to how many people have the same ID.
            // For example BD001 is first student with that number. Burak Dogan BD,
            // Adding Burak Dere, is still BD. But since Burak Dogan is 1st to be created BD001,
            // and BD002 for the Burak Dere student.

            // If and only if letter part of a new student matches, then BD002 is created.
            // Since the method will not create duplicates, it is still a valid solution

            string sID = String.Concat(FName.Substring(0, 1).ToUpper(), LName.Substring(0, 1).ToUpper());
            int runningNumber = 0;

            string number = String.Format("{0:D5}", runningNumber);
            runningNumber += Students.Where(x => x.SID.StartsWith(sID)).Count() + 1;
            sID = String.Concat(sID, runningNumber.ToString().PadLeft(3, '0'));
           
            return sID;

        }


        public void PrintStudents()
        {

            Console.WriteLine($"First student in Register:\n{Students.First()}\n\nLast student in Register:\n{Students.Last()}\n");

            Console.WriteLine($"\nThere are {Students.Count} students in the register\n");

            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }           

        }

        public void PrintStudentsAplhabetically() 
        {
            // Sort by firstname
            var sortedList = Students.OrderBy(x => x.FName).ToList();

            Console.WriteLine("-----------\n\nStudents in alphabetical order:\n-----------");
            foreach (var student in sortedList)
            {
                Console.WriteLine(student.FName + " " + student.LName);
            }
        }


        public string RemoveStudent()
        {
            Console.WriteLine("To remove student enter SID:");
            var sid = Console.ReadLine().ToUpper();

            var student = Students.FirstOrDefault(x => x.SID == sid);

            if (student != null)
            {
                string removed = student.FName + " " + student.LName;
                Students.Remove(student);
                Console.WriteLine($"Student {removed} removed successfully!");
            }
            else
            {
                Console.WriteLine("No student found!");
            }
            return "";

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Register studentRegister = new(default, default, default, default);
           
            
            studentRegister.AddStudents("Halil", "Huso", "TTV20S1");
            studentRegister.AddStudents("Hanna", "Husso", "TTV19S1");            
            studentRegister.AddStudents("Karen", "Keran", "TTV21S2");
            studentRegister.AddStudents("Masa", "Niemi", "TTV19S3");
            studentRegister.AddStudents("Kirsi", "Kernel", "TTV19S2");
            studentRegister.AddStudents("Mersi", "Nil", "TTV19S4");            
            studentRegister.AddStudents("Allan", "Aalto", "TTV19SMM");
            studentRegister.AddStudents("Teppo", "Tester", "TIC21S");


            int i = 0;
            while (i == 0)
            {

                Console.WriteLine("\n-------------------------------\nChoose:\n 1) Add a student\n 2) View students\n 3) Remove a students\n 4) Print students alphabetically\n 5) Quit\n-------------------------------");
                
                switch (Console.ReadLine())
                {
                    case "1":
                        studentRegister.AddStudent();
                        break;

                    case "2":
                        studentRegister.PrintStudents();
                        break;

                    case "3":
                        studentRegister.RemoveStudent();
                        break;

                    case "4":
                        studentRegister.PrintStudentsAplhabetically();
                        break;

                    case "5":
                        i++;
                        break;


                }
            }
        }
    }
}