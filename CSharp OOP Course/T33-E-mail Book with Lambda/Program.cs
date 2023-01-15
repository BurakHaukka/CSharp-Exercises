namespace T33
{
    public class Friend
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public Friend(string name, string email)
        {
            Name = name;
            Email = email;

        }
        public override string ToString()
        {
            return $"{Name} {Email}";
        }
    }
    public class MailBook
    {
        public List<Friend> friendEmails = new List<Friend>();


        public string Search(string userInput)
        {
            //Here Lambda overcomes case sensitivity issues.
            var results = friendEmails.Where(friend => friend.Name.IndexOf(userInput, StringComparison.OrdinalIgnoreCase) >= 0);
            return ($"\nResult count {results.Count()}\n" + String.Join("\n", results));
        }
        public string ReadMailBook()
        {
            List<string> emails = new();
            List<string> names = new List<string>();

            // Reads the lines of the csv file, saves names as names, emails as emails.
            // This method can not take variable as input in my experience so file path is hardcoded...with my home folder
            try
            {
                using (var sr = new StreamReader(@"C:\Users\olurt\friends.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        var info = line.Split(';');

                        var name = info[0].Split(',')[0];
                        names.Add(name);

                        var email = info[0].Split(',')[1];
                        emails.Add(email);

                        friendEmails.Add(new Friend(name, email));

                    }
                }
                return string.Join($"\n", names);
            }
            catch (FileNotFoundException ex)
            {
                return $"File does not exist {ex}";
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var userDir = new DirectoryInfo(Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile));

            MailBook mailBook = new MailBook();
            Console.WriteLine(mailBook.ReadMailBook());

            Console.WriteLine("\nEnter the name or part of the name of the person you are looking for: ");
            var userInput = Console.ReadLine();

            Console.WriteLine(mailBook.Search(userInput));

            Console.WriteLine($"\nWould you like to add a new person? (y/n) ");
            string decision = Console.ReadLine();

            if (decision == "y") 
            {
                Console.WriteLine("\nNew Friend Name?:");
                var newName = Console.ReadLine();

                Console.WriteLine("\nNew Friend E-mail?:");
                var newEmail = Console.ReadLine();
                string newPerson = newName + "," + newEmail + ";\n";

                try
                {
                    System.IO.File.AppendAllText($@"{userDir}\friends.csv", newPerson);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"File does not exist {ex}");
                }

                Console.WriteLine("--- Updated List ---");                
                Console.WriteLine(mailBook.ReadMailBook());
                Console.WriteLine($"\nTried to add {newName} {newEmail} to the MailBook.\n");
                Console.WriteLine($"\nProgram ended...\n");
            }


        }
    }
}