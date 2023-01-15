internal class Program
{
    public class ElDevice 
    {

        public bool On;
        public float Power { get; set; }
        public string switchh; 
        public bool Switch (string switchh)
        {
            if (switchh == "ON")
            {
                On = true;
                return true;
            }
            else if (switchh == "OFF")
            {
                On = false;
            } return false;
        }

    }

    public class PortableRadio : ElDevice
    {
        public int volume;
        public int invol;
       
        public int Volume()
        {
            if (On == true && 0 <= invol && invol <= 9)
            {
                volume = invol;
                return volume;
            }
            else
            {
               volume = 0;
                return volume;
            }
        }
      

        public float freq;
        public float Freq;
        public float Frequency()
        {
            if (On == true && 2000.0F <= freq && freq <= 26000.0F)
            {
                Freq = freq;
                return freq;
            }
            else 
            {
                Freq = 0;
                return 0;
            }

        }

        public string ToString() 
        {
                return $"Switch: {switchh}\nVolume: {volume}\nFrequency: {Freq}\n";
        }
    }
    private static void Main(string[] args)
    {
        PortableRadio radio = new PortableRadio() { switchh = "ON", invol = 5, freq = 2000 } ;
        radio.Switch(radio.switchh);
        radio.Frequency();
        radio.Volume();
        Console.WriteLine(radio.ToString());


        PortableRadio radio2 = new PortableRadio() { switchh = "ON", invol = 11, freq = 10 };
        radio2.Switch(radio2.switchh);
        radio2.Frequency();
        radio2.Volume();
        Console.WriteLine(radio2.ToString());
        

        PortableRadio radio3 = new PortableRadio() { switchh = "OFF", freq = 2132, invol = 4 };
        radio3.Switch(radio3.switchh);
        radio3.Frequency();
        radio3.Volume();
        Console.WriteLine(radio3.ToString());
        

        PortableRadio radio4 = new PortableRadio() { switchh = "OFF", freq = 260001, invol = -1 };
        radio4.Switch(radio4.switchh);
        radio4.Frequency();
        radio4.Volume();
        Console.WriteLine(radio4.ToString());
        


    }
}