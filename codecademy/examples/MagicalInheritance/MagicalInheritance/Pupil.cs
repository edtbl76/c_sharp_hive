namespace MagicalInheritance;

public class Pupil
{
    protected string Title { get; init; }

    public Pupil(string title)
    {
        Title = title;
    }

    public Storm CastWindStorm()
    {
        return new Storm("wind", false, Title);
    }
}