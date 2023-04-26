namespace MagicalInheritance;

public class ArchMage : Mage
{
    public ArchMage(string title) : base(title)
    {
        Title = title;
    }

    public override Storm CastRainStorm()
    {
        return new Storm("rain", true, Title);
    }

    public Storm CastLightningStorm()
    {
        return new Storm("lightning", true, Title);
    }
}