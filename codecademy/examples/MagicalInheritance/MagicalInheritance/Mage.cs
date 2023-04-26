namespace MagicalInheritance;

public class Mage : Pupil
{
    public Mage(string title) : base(title)
    {
        Title = title;
    }

    public virtual Storm CastRainStorm()
    {
        return new Storm("rain", false, Title);
    }
}