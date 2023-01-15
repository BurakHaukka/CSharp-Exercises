internal class Program
{
    public class Television
    {
        public int Volume { get; set; } // 0-100
        public int Channel { get; set; } //NUmber of the channel
        public string Source { get; set; } // Where Tv gets its media. 
        
        public bool Power = false; // On-Off



        public string tvState
        {
            get
            {
                if (Power == true)
                    return "ON";
                else
                {
                    return "OFF";
                }
            }
            set { }
        }
        public string userRemote(string state, int userChan, int userVol, string userSource)
        {
            if (state == "y")
            {
                Power = true;
                Volume = userVol;
                Channel = userChan;
                Source = userSource;

                return $"\n\nTv is '{tvState}' \n\nChannel is set to {Channel} \n\nVolume is '{Volume}'\n\nYou are Viewing from {Source}.";
            }
            else if (state == "n")
            {
                Power = false;
                Volume = 0;
                Channel = 0;
                return $"\n\nTv is '{tvState}'.";
            }
            return "";
        }


    }
    internal class TvRemote
    {


        private static void Main(string[] args)
        {
            int userVol = 0;
            int userChan = 0;
            string userSource = ""; // 
            string state = ""; // user turns ON or OFF
            


            Television NotSoSmartTV = new Television();

            //OFF state
            NotSoSmartTV.Power = false;
            NotSoSmartTV.Channel = 0;
            NotSoSmartTV.Volume = 0;

            // Washing machine user input

            Console.WriteLine("Would you like to turn on the TV ? (Type 'y' for yes & 'n' for no)");
            state = Console.ReadLine();

            if (state == "y")
            {
                Console.WriteLine("Type in the channel you want (Only numbers ! )");
                userChan = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Set the Volume ( 0-100 Go lound at your own risk! Only numbers ! ) : ");
                userVol = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What source you are using (HDMI, Antenna, Internet) : ");
                userSource = Console.ReadLine();

                Console.WriteLine(NotSoSmartTV.userRemote(state, userChan, userVol, userSource));
            }
            else
            {
                Console.WriteLine(NotSoSmartTV.userRemote(state, userChan, userVol, userSource));
            }





        }
    }
}
