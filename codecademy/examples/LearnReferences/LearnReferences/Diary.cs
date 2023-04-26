namespace LearnReferences;

public class Diary : Book, IFlippable
{
    public int CurrentPage { get; set; }

    public Diary(int page = 0)
    {
        CurrentPage = page;
    }

    public Diary(int page, string author, string title) : base(author, title)
    {
        CurrentPage = page;
    }
    
    public void Flip()
    {
        CurrentPage++;
    }

    public static string SpillSecret()
    {
        return "OMG Ed likes Vanessa <3!";
    }

    public override string Stringify()
    {
        return "This is a Diary object!";
    }
}