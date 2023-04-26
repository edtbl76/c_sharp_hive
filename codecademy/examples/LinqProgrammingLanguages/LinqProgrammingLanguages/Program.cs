using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace  LinqProgrammingLanguages;

internal static class Program
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static void Main()
    {
        
        var languages = File.ReadAllLines("/Users/edwardmangini/PycharmProjects/codeacademy/learn_c#/examples/LinqProgrammingLanguages/LinqProgrammingLanguages/languages.tsv")
            .Skip(1)
            /*
             * This is usually
             *  .Select(line => Language.FromTsv(line))
             *
             * Similar to Java, we can shorten the syntax to what C# calls a Method Group.
             */
            .Select(Language.FromTsv)
            .ToList();
        
        // Print 'em
        PrettyPrintAll(languages); 
        
        Console.WriteLine("\n------- C# -------");
        var cSharp = languages.Where(language => language.Name.Contains("C#"));
        PrettyPrintAll(cSharp);
        
        Console.WriteLine("\n------- Microsoft -------");
        var microsoft = languages.Where(language => language.ChiefDeveloper.Contains("Microsoft"));
        PrettyPrintAll(microsoft);
        
        Console.WriteLine("\n------- Lisp Predecessors -------");
        var lispPredecessors = languages.Where(language => language.Predecessors.Contains("Lisp"));
        PrettyPrintAll(lispPredecessors);
        
        Console.WriteLine("\n------- xScript -------");
        var scriptLanguages = languages.Where(language => language.Name.Contains("Script"));
        PrettyPrintAll(scriptLanguages);
        
        Console.WriteLine("\n------- No of Languages -------");
        Console.WriteLine(languages.Count);
        
        Console.WriteLine("\n------- No of Languages between 1995 and 2005 -------");
        var language1995To2005 =
            languages.Where(language => language.Year is >= 1995 and <= 2005);
        
        Console.WriteLine(language1995To2005.Count());
        PrintAll(language1995To2005.Select(language => $"{language.Name} was invented in {language.Year}"));


    }

    private static void PrettyPrintAll(IEnumerable<Language> languages)
    {
        foreach (var language in languages)
        {
           Console.WriteLine(language.Prettify());
        }
    }

    private static void PrettyPrintAll(List<Language> languages)
    {
        foreach (var language in languages)
        {
            Console.WriteLine(language.Prettify());
        }
    }

    private static void PrintAll(IEnumerable<object> objects)
    {
        foreach (var obj in objects)
        {
            Console.WriteLine(obj);
        }
    }
}