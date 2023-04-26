namespace LearnInheritance;

public abstract class Vehicle
{
    public string LicensePlate { get; }
    public double Speed { get; protected set; }
    public int Wheels { get; protected init;  }

    protected Vehicle(double speed)
    {
        Speed = speed;
        LicensePlate = Tools.GenerateLicensePlate();
    }
    
    public virtual void Honk()
    {
        Console.WriteLine("HONK!");
    }

    public virtual void SpeedUp()
    {
        Speed += 5;
    }

    public virtual void SlowDown()
    {
        Speed -= 5;
    }

    public abstract string Describe();
}