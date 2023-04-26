namespace LearnInheritance;

public class Bicycle: Vehicle 
{
    public Bicycle(double speed) : base(speed)
    {
        Wheels = 2;
    }

    public override void SpeedUp()
    {
        Speed += 5;
        Speed = (Speed > 15) ? 15 : Speed;
    }

    public override void SlowDown()
    {
        Speed -= 5;
        Speed = (Speed < 0) ? 0 : Speed;
    }

    public override string Describe()
    {
        return $"This bicycle is moving on {Wheels} wheels at {Speed} mph, with license plate {LicensePlate}";
    }
}