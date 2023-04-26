using System;

namespace LearnInheritance 
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var sedan = new Sedan(60);
            Console.WriteLine(sedan.Describe());
            sedan.SpeedUp();
            Console.WriteLine($"Sedan's faster speed: {sedan.Speed}");
      
            var truck = new Truck(45, 500);
            Console.WriteLine(truck.Describe());
            truck.SpeedUp();
            Console.WriteLine($"Truck's faster speed: {truck.Speed}");

            var bicycle = new Bicycle(10);
            Console.WriteLine(bicycle.Describe());
            bicycle.SpeedUp();
            Console.WriteLine($"Bike's faster speed: {bicycle.Speed}");
        }
    }
}