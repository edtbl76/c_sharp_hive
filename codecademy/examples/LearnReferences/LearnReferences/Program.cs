using System;

namespace LearnReferences;

internal static class Program
{
    private static void Main(string[] args)
    {
        // References/Values -> Polymorphism step 1
        var dissertation1 = new Dissertation(32, "Anna Knowles-Smith", "Refugees and Theatre");
        var dissertation2 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
        var diary1 = new Diary(48, "Anne Frank", "The Diary of a Young Girl");
        var diary2 = new Diary(23, "Lili Elbe", "Man into Woman");

        var books = new Book[] {dissertation1, dissertation2, diary1, diary2};

        foreach (var book in books)
        {
            Console.WriteLine(book.Title);
        }
        
        // Polymorphism step 2 -> Same Reference Type, Different Object
        var book1 = new Book("Warren Berger", " A More Beautiful Question");
        Book book2 = new Diary(1);
        Console.WriteLine(book1.Stringify());
        Console.WriteLine(book2.Stringify());
        
    }
}