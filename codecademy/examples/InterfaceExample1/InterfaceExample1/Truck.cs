namespace InterfaceExample1;

public class Truck : IAutomobile
{
    public Truck(double speed, double weight)
    {
        Weight = weight;
        Speed = speed;
        Wheels  = (weight < 400) ? 8 : 12;
        LicensePlate = Tools.GenerateLicensePlate();
    }

    public string LicensePlate { get; }
    public double Speed { get; private set;  }
    public int Wheels { get; }
    public double Weight { get;  }
    
    public void Honk()
    {
        Console.WriteLine("BLEEEEEAAAAAAAAT"); 
    }

    public void SpeedUp()
    {
        Speed += 5;
    }

    public void SlowDown()
    {
        Speed -= 5;
    }
}