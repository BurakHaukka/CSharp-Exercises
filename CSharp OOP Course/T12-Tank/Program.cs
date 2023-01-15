using System.Security.Cryptography.X509Certificates;

public class Tank
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int crewSize = 4;
    public int CrewSize 
    { get { return crewSize; }
      set 
        {
            if (value >= 2 && value <= 6) 
            {
                crewSize = value;
            }
        } 
    }
    public float Speed 
    {
        get { return speed; }
    }

    public const int MinCrew = 2;
    public const int MaxCrew = 6;

    public float speed = 0;
    public const float SpeedMax = 100;
    public const float SpeedMin = 0;

    

    public float AccelerateTo(float inputSpeed) 
    {
        if (inputSpeed <= SpeedMax) 
        {
            speed = inputSpeed;
        }

        return speed;
    }

    public float SlowTo(float inputSpeed)
    {
        if (inputSpeed >= SpeedMin)
        {
            speed = inputSpeed;
        }
        return speed;
    }

    public int AssignCrew(int inputCrewSize) 
    {
        if ( MinCrew <= inputCrewSize && inputCrewSize <= MaxCrew)
        {
            CrewSize = inputCrewSize;
        }
        return CrewSize;
    }

    public virtual string ToString() 
    {
        return $"Tank: {Name}\nType: {Type}\nCrew Size: {CrewSize}\nCrew: {CrewSize}\nCurrent Speed: {Speed}\n";
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Tank Typhoon = new Tank() { Name = "Typhoon", Type = "Artillery", CrewSize = 10 };
        Typhoon.AccelerateTo(500);
        Console.WriteLine(Typhoon.ToString());
        Typhoon.SlowTo(-1);
        Console.WriteLine(Typhoon.ToString());

        Tank Panther = new Tank() { Name = "Panther", Type = "Heavy", CrewSize = 4 };
        Panther.AccelerateTo(50);
        Console.WriteLine(Panther.ToString());
        Panther.SlowTo(20);
        Console.WriteLine(Panther.ToString());
    }
}