namespace MagicalInheritance;

public class Storm
{
    private string Essence { get; }
    private bool IsStrong { get; }
    private string Caster { get; }

    public Storm(string essence, bool isStrong, string caster)
    {
        Essence = essence;
        IsStrong = isStrong;
        Caster = caster;
    }

    public string Announce()
    {
        var message = (IsStrong) ? "strong" : "weak";
        return $"{Caster} cast a {message} {Essence} storm.";
    }
}