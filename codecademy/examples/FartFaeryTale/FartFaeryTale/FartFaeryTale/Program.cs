// See https://aka.ms/new-console-template for more information
using System;

namespace FartFaeryTale
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const string beginning = "Once upon a time";
            const string middle = "I farted";
            const string end = "The end";
            
            // example with concatenation
            const string concatenatedStory = beginning + ", " + middle + ". " + end + ".";
            Console.WriteLine(concatenatedStory);
            
            // example with interpolation
            const string interpolatedStory = $"{beginning}, {middle}. {end}.";
            Console.WriteLine(interpolatedStory);

        }
    }
}