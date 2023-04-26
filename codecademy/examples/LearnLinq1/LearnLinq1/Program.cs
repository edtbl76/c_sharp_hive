using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq1;

internal static class Program
{
    private static void Main()
    {
        string[] heroes = {"Aquaman", "Superman", "Green Lantern", "Wonder Woman", "Flash", "Batman", "J'onn J'onzz"};

        var methodSyntax = heroes.Select(hero => $"Introducing...{hero}!");
        foreach (var hero in methodSyntax)
        {
            Console.WriteLine(hero);
        }

        var querySyntax =
            from hero in heroes
            where hero.Contains(' ')
            select hero.IndexOf(' ');

        foreach (var index in querySyntax)
        {
            Console.WriteLine($"Index: {index}");
        }


    }
}