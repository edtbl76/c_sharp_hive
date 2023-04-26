namespace LearnInheritance;

public class Truck : Vehicle, IAutomobile
{

    public double Weight { get;  }

    public Truck(double speed, double weight) : base(speed)
    {
        Weight = weight;
        Wheels = (weight < 400) ? 8 : 12;
    }

    public override void Honk()
    {
       Console.WriteLine("LOUD HONK!"); 
    }

  
    public override string Describe()
    {
        return $"This truck, that weighs {Weight} pounds, is moving on {Wheels} wheels at {Speed} mph, with " +
               $"license plate {LicensePlate}";
    }
    
}