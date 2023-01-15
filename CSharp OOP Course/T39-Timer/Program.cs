using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace T39
{
    internal class Program
    {
        public class Timer
        {
            public int DefaultSec = 0;
            public int UserSec
            {
                get { return DefaultSec; }
                set
                {
                    if (value <= 60)
                    {
                        DefaultSec = value;
                    }
                }
            }

            public int DefaultMin = 0;
            public int UserMin 
            { get { return DefaultMin; }
                set 
                {
                    if (value <= 60) 
                    {
                        DefaultMin = value;
                    }
                    
                }
            }
            
            public string DefaultMessage = "\nWake wake, little bird!\n";
            public string Message { get { return DefaultMessage; }
                set 
                {
                    DefaultMessage = value;
                }
            }
            
            public void Alarm() 
            {
                int SecToMilSec = UserSec * 1000;
                int MinToMilSec = UserMin * 60000;
                int TotalMilSec = SecToMilSec + MinToMilSec;

                Stopwatch Reminder = new Stopwatch();
                Reminder.Start();
                Thread.Sleep(TotalMilSec);
                Reminder.Stop();

                Console.WriteLine(Message);
                TimeSpan timeSpan = Reminder.Elapsed;

                string alarmSet = String.Format("{0:00}:{1:00}:{2:00}", 
                                                                        timeSpan.Hours,
                                                                        timeSpan.Minutes,
                                                                        timeSpan.Seconds);
                Console.WriteLine("Time is up !!: " + alarmSet + "\n");
            }
                
        }
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            
            Console.WriteLine("You can use this app set reminders for yourself.\nYou can add custom message or leave it blank.\n----Timer accepts 1 second to 60 min input----");
            
            Console.WriteLine("Give seconds for timer. If you dont want to set seconds, leave it blank and press Enter: ");
            string inputSec = Console.ReadLine();
            if (String.IsNullOrEmpty(inputSec))
            {
                
            }
            else 
            {
                timer.UserSec = Convert.ToInt32(inputSec);
            }
            

            Console.WriteLine("Give minutes for timer. If you dont want to set minutes, leave it blank and press Enter (max. 60 mins): ");
            string inputMin = Console.ReadLine();
            if (String.IsNullOrEmpty(inputMin))
            {

            }
            else
            {
                timer.UserMin = Convert.ToInt32(inputMin);
            }
            

            Console.WriteLine($"Alarm is set for {timer.UserMin} minutes and {timer.UserSec} seconds.\n---- Sit back, relax and keep an eye on console ! :) ----");

            timer.Alarm();
        }
    }
}
