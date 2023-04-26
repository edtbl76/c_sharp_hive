// See https://aka.ms/new-console-template for more information
using System;

namespace NameMaker
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const string name = "Edward Mangini";

            var index = name.IndexOf("E", StringComparison.Ordinal);
            var firstLetter = name[index];

            index = name.IndexOf("Mangini", StringComparison.Ordinal);
            // Using range indexer instead of name.Substring(index);
            var lastName = name[index..];
            
            Console.WriteLine($"Name  : {firstLetter.ToString().ToUpper()}. {lastName.ToUpper()}");
            Console.WriteLine($"Email : {firstLetter.ToString().ToLower()}{lastName.ToLower()}@csharp.com");
            
        }
    }
}