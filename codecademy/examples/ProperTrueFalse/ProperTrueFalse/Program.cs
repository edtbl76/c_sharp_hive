using System;

namespace ProperTrueFalse
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Get Input
            Console.WriteLine("Welcome to 'True or False'?\nPress Enter to begin: ");
            var entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);
        }
    }
}