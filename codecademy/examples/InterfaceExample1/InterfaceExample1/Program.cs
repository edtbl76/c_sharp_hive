using System;
namespace InterfaceExample1;

internal class Program
{
    public static void Main(string[] args)
    {
        var sedan1 = new Sedan(60);
        var sedan2 = new Sedan(70);
        var truck = new Truck(45, 500);
        
        Console.WriteLine("Sedan1: ");
        Console.WriteLine($"  Speed  : {sedan1.Speed}");
        Console.WriteLine($"  Wheels : {sedan1.Wheels}");
        Console.WriteLine($"  Plates : {sedan1.LicensePlate}");
        
        Console.WriteLine("Sedan2: ");
        Console.WriteLine($"  Speed  : {sedan2.Speed}");
        Console.WriteLine($"  Wheels : {sedan2.Wheels}");
        Console.WriteLine($"  Plates : {sedan2.LicensePlate}");
        
        Console.WriteLine("Truck: ");
        Console.WriteLine($"  Speed  : {truck.Speed}");
        Console.WriteLine($"  Wheels : {truck.Wheels}");
        Console.WriteLine($"  Plates : {truck.LicensePlate}");
        
        
        sedan1.SpeedUp();
        sedan2.SpeedUp();
        truck.SpeedUp();
        
        Console.WriteLine($"Sedan1 New Speed: {sedan1.Speed}");
        Console.WriteLine($"Sedan2 New Speed: {sedan2.Speed}");
        Console.WriteLine($"Truck  New Speed: {truck.Speed}");
    }
}


