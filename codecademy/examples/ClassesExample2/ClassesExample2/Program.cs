namespace ClassesExample2
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Constructor
            var forest = new Forest("Sherwood", "Boreal")
            // object initializer rather than using setter/property assignment.
            {
                Trees = 0
            };

            Console.WriteLine("New Forest");
            Console.WriteLine($"Name  : {forest.Name}");
            Console.WriteLine($"Trees : {forest.Trees}");
            Console.WriteLine($"Biome : {forest.Biome}");
            Console.WriteLine($"Age   : {forest.Age}");

            Console.WriteLine("\nGrow Forest:");
            var currentTrees = forest.Grow();
            Console.WriteLine($"Trees : {currentTrees}");
            Console.WriteLine($"Age   : {forest.Age}");

            Console.WriteLine("\nBurn Forest: ");
            currentTrees = forest.Burn();
            Console.WriteLine($"Trees : {currentTrees}");
            Console.WriteLine($"Age   : {forest.Age}");
            

        }
    }
}