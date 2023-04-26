namespace RoverControlCenter;

public sealed class Satellite : Probe, IDirectable
{
    private string Alias { get; }
    private int YearLaunched { get; }

    public Satellite(string alias, int yearLaunched)
    {
        Alias = alias;
        YearLaunched = yearLaunched;
    }

    public string GetInfo()
    {
        return $"Alias: {Alias}, YearLaunched: {YearLaunched}";
    }

    public string Explore()
    {
        return "Satellite is exploring the far reaches of space!";
    }

    public string Collect()
    {
        return "Satellite is collecting photographic evidence!";
    }
}