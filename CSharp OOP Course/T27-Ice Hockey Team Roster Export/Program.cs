using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static T26.Program;

namespace T26
{
    internal class Program
    {
        public class Team
        {
            public string team;
            public string Name { get; set; }
            public string Hometown { get; set; }
            public List<Player> Players { get { return players; } }

            private List<Player> players = new List<Player>();

            public string ToString()
            {
                return $"Name: {Name}\nHome Town: {Hometown}\n";
            }

            public Team(string team)
            {
                Name = team;
                players = new List<Player>();

                switch (team)
                {
                    case "JYP":
                        Hometown = "Jyväskylä";
                        //Team JYP = new Team(team) { Hometown = "Jyväskylä" };
                        AddPlayers(team);

                        break;

                    case "Kalpa":
                        Hometown = "Kuopio";
                        //Team Kalpa = new Team(team) { Hometown = "Kuopio" };
                        AddPlayers(team);

                        break;

                        //case "Tappara":

                        //    AddPlayers(team);
                        //    break;
                }




            }



            void AddPlayers(string team)
            {
                switch (team)
                {
                    case "JYP":

                        //Clear the list then create-add new players
                        players.Clear();

                        Player player1 = new Player() { FName = "Samuel", Sname = "Helenius", Position = "C", Number = 14 };
                        Player player2 = new Player() { FName = "Antoni", Sname = "Honka", Position = "D", Number = 3 };
                        Player player3 = new Player() { FName = "Antti", Sname = "Kalapudas", Position = "C/LW", Number = 51 };
                        Player player4 = new Player() { FName = "Brad", Sname = "Lambert", Position = "C", Number = 92 };
                        Player player5 = new Player() { FName = "Patrik", Sname = "Puistola", Position = "W", Number = 21 };

                        players.Add(player1);
                        players.Add(player2);
                        players.Add(player3);
                        players.Add(player4);
                        players.Add(player5);

                        break;

                    case "Kalpa":

                        players.Clear();

                        Player player6 = new Player() { FName = "Gabe", Sname = "Bast", Position = "D", Number = 10 };
                        Player player7 = new Player() { FName = "Hugo", Sname = "Gallet", Position = "D", Number = 18 };
                        Player player8 = new Player() { FName = "Juha", Sname = "Jatkola", Position = "G", Number = 32 };
                        Player player9 = new Player() { FName = "Severi", Sname = "Immonen", Position = "F", Number = 34 };
                        Player player10 = new Player() { FName = "Matti", Sname = "Järvinen", Position = "C", Number = 71 };

                        players.Add(player6);
                        players.Add(player7);
                        players.Add(player8);
                        players.Add(player9);
                        players.Add(player10);

                        break;

                        //case "Tappara":
                        //    Hometown = "Tampere";
                        //    AddPlayers(team);
                        //    break;
                }
            }


        }



        public class Player
        {
            public string FName { get; set; }
            public string Sname { get; set; }
            public string Position { get; set; }
            public int Number { get; set; }

            public string ToString()
            {
                return $"Name: {FName}\nSurname: {Sname}\nPosition: {Position}\nJersey Number: {Number}\n";
            }

        }
        static void Main(string[] args)
        {
            string input;

            int i = 0;
            var userDir = new DirectoryInfo(Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile));
            Console.WriteLine(userDir);


            do
            {
                Console.WriteLine("Give name for a team JYP or Kalpa or Tappara (Press Enter to stop):");
                input = Console.ReadLine();
                

                if (input == "JYP")
                {
                    Team JYP = new Team(input);
                    StringBuilder players = new StringBuilder();
                   

                    Console.WriteLine("\n**** Team JYP ****\n");
                    Console.WriteLine(JYP.ToString());
                    Console.WriteLine("\n**** Team Players ****\n");
                    foreach (Player item in JYP.Players)
                    {
                        players.AppendFormat("{0};{1};{2};{3}",item.FName, item.Sname, item.Position, item.Number );
                        players.AppendLine();
                        Console.WriteLine(item.ToString());
                    }

                    Console.WriteLine(players.ToString());
                    System.IO.File.WriteAllText($@"{userDir}\JYP.csv", players.ToString());
                    Console.WriteLine($"PLayer list saved to JYP.csv at folder {userDir}");
                }
                else if (input == "Kalpa")
                {
                    Team Kalpa = new Team(input);
                    StringBuilder players2 = new StringBuilder();

                    Console.WriteLine("\n**** Team Kalpa ****\n");
                    Console.WriteLine(Kalpa.ToString());
                    Console.WriteLine("\n**** Team Players ****\n");
                    foreach (Player item in Kalpa.Players)
                    {
                        players2.AppendFormat("{0};{1};{2};{3}", item.FName, item.Sname, item.Position, item.Number);
                        players2.AppendLine();
                        Console.WriteLine(item.ToString());
                    }

                    Console.WriteLine(players2.ToString());
                    Console.WriteLine(players2.ToString());
                    System.IO.File.WriteAllText($@"{userDir}\Kalpa.csv", players2.ToString());
                    Console.WriteLine($"PLayer list saved to Kalpa.csv at folder {userDir}");
                }
                else
                {
                    i++;
                }

            } while (i == 0);

        }
    }
}
