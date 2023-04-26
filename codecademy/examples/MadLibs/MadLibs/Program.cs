// See https://aka.ms/new-console-template for more information
using System;

namespace MadLibs
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            /*
             *  Program: Mad Libs
             *  Author: Ed Mangini
             */
            
            Console.WriteLine("=====================");
            Console.WriteLine("Mad Libs is starting.");
            Console.WriteLine("=====================");

            const string title = "Story Title";
            Console.WriteLine(title);

            // input and variables
            Console.Write("Enter a name: ");
            var name = Console.ReadLine();
            
            Console.Write("Enter first adjective: ");
            var adjective1 = Console.ReadLine();
            Console.Write("Enter second adjective: ");
            var adjective2 = Console.ReadLine();
            Console.Write("Enter third adjective: ");
            var adjective3 = Console.ReadLine();
            
            Console.Write("Enter a verb: ");
            var verb = Console.ReadLine();
            
            Console.Write("Enter first noun: ");
            var noun1 = Console.ReadLine();
            Console.Write("Enter second noun: ");
            var noun2 = Console.ReadLine();
            
            Console.Write("Enter a type of animal: ");
            var animal = Console.ReadLine();
            
            Console.Write("Enter a type of food: ");
            var food = Console.ReadLine();
            
            Console.Write("Enter a type of fruit: ");
            var fruit = Console.ReadLine();
            
            Console.Write("Enter a superhero: ");
            var superhero = Console.ReadLine();

            Console.Write("Enter a country: ");
            var country = Console.ReadLine();
            
            Console.Write("Enter a type of dessert: ");
            var dessert = Console.ReadLine();
            
            Console.Write("Enter a year: ");
            var year = Console.ReadLine();
            
            
            var story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' " +
                        $"Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} " +
                        $"to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, " +
                        $"{name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle " +
                        $"of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled " +
                        $"the world."; 
            
            Console.WriteLine(story);
        }
    }
}