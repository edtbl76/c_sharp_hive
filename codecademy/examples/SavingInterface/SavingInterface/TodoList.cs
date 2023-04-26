namespace SavingInterface;

public class TodoList : IDisplayable, IResetable
{
    private string[] Todos { get; set; }

    private int _nextOpenIndex;

    public TodoList()
    {
        Todos = new string[5];
        _nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
        Todos[_nextOpenIndex] = todo;
        _nextOpenIndex++;
    }

    public void Display()
    {
        Console.WriteLine("TodoList: ");
        foreach (var todo in Todos)
        {
            Console.WriteLine($" - {todo}");
        }
    }

    public void Reset()
    {
        Todos = new string[5];
        _nextOpenIndex = 0;
    }
}