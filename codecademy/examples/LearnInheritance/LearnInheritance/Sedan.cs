namespace LearnInheritance;

/*
 * All of the methods and members have been removed, because Sedan is a subclass of Vehicle.
 * - Since Vehicle has already defined these methods, I don't have to provide them here.
 *
 * - However, I can't SET any of the properties, because they are private by default.
 *      in Vehicle, I have adjusted the properties to have `protected` setters,
 *      which makes the methods and properties available to subclasses. 
 */
public class Sedan : Vehicle, IAutomobile
{
    /*
     * if base isn't explicitly specified, then
     * it is implied as base().
     *
     * Here we are calling base(speed) in order to pass our argument
     * to the Vehicle superclass.
     *
     * NOTE: (We've removed LicensePlate and Speed because these are provided
     *          by Vehicle)
     */
    public Sedan(double speed) : base(speed)
    {
        Wheels = 4;
    }

    public override void Honk()
    {
        Console.WriteLine("BeepBeep!");
    }

    public override string Describe()
    {
        return $"This sedan is moving on {Wheels} wheels at {Speed} mph, with license plate {LicensePlate}";
    }
}