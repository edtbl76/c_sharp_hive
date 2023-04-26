namespace RoverControlCenter;

public class Rover : Probe, IDirectable
{
    private string Alias { get; }
    private int YearLanded { get; }

    protected Rover(string alias, int yearLanded)
    {
        Alias = alias;
        YearLanded = yearLanded;
    }

    public string GetInfo()
    {
        return $"Alias: {Alias}, YearLanded: {YearLanded}";
    }

    public virtual string Explore()
    {
        return "Rover is exploring the surface!";
    }

    public virtual string Collect()
    {
        return "Rover is collecting rocks!";
    }
}