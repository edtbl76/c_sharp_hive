using System;

namespace ClassesEx1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var forest = new Forest();
            forest.Name = "Sherwood";
            forest.Trees = 0;
            forest.age = 0;
            forest.biome = "Tundra";
            
            Console.WriteLine(forest.Name);
        }
    }
}