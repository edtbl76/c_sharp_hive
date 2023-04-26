namespace InterfaceExample1;

public class Sedan : IAutomobile
{
    
    // Constructors
    public Sedan(double speed)
    {
        Speed = speed;
        LicensePlate = Tools.GenerateLicensePlate();
        Wheels = 4;
    }
    
    // Properties
    public string LicensePlate { get; }
    public double Speed { get; private set; }
    public int Wheels { get; }
    
    // Methods
    public void Honk()
    {
       Console.WriteLine("Beep!"); 
    }

    public void SpeedUp() { Speed += 5; }

    public void SlowDown()
    {
        Speed -= 5;
    }
    
    
}