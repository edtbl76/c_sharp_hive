using System;

namespace OutParameter
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Define Variables
            const string destination = "Neptune";
            const string galaxyString = "8";

            int galaxyInt;
            string welcomeMessage;
            bool outcome;
            
            // Call Methods. 
            welcomeMessage = DecoratePlanet(destination);
            outcome = int.TryParse(galaxyString, out galaxyInt);
            
            // Print results
            Console.WriteLine(welcomeMessage);
            Console.WriteLine($"Parsed to int? {outcome}: {galaxyInt}");
        }

        private static string DecoratePlanet(string planet)
        {
            return $"*..*..* {planet} *..*..*";
        }
        
    }
}