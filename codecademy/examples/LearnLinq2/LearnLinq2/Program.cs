using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq2;

internal static class Program
{
    private static void Main()
    {
        var heroes = new List<string>
        {
            "Atom", "Hawkman", "Green Arrow", "Black Canary", "Firestorm", "Red Tornado", "Elongated Man"
        };

        var heroQuery =
            heroes.Where(hero => hero.Contains(' ') || hero.ToUpper().Contains("MAN"));

        foreach (var hero in heroQuery)
        {
            Console.WriteLine(hero);
        }
    }
}