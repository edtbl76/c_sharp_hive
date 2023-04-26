using System;

namespace SwitchStatement
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pick a genre: ");
            var genre = Console.ReadLine();

            switch (genre) {
                case "Drama":
                    Console.WriteLine("Field of Dreams");
                    break;
                case "Comedy":
                    Console.WriteLine("Ferris Bueller's Day Off");
                    break;
                case "Adventure":
                    Console.WriteLine("Raiders of the Lost Ark");
                    break;
                case "Horror":
                    Console.WriteLine("Halloween");
                    break;
                case "Science Fiction":
                    Console.WriteLine("Star Wars");
                    break;
                default:
                    Console.WriteLine("No movie found");
                    break;
            }

        }
    }
}