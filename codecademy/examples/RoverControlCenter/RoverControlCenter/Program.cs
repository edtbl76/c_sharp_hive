using System;

namespace RoverControlCenter;

internal static class Program
{
    public static void Main(string[] args)
    {
        
        /*
         *  Section 1: Reference only Polymorphism
         */
        var lunokhod = new MoonRover("Lunokhod 1", 1970);
        var apollo = new MoonRover("Apollo 15", 1971);
        var sojourner = new MarsRover("Sojourner", 1997);
        var sputnik = new Satellite("Sputnik", 1957);
        
        // Store Rovers in array type of Rover
        var rovers = new Rover[] {lunokhod, apollo, sojourner};
        DirectAll(rovers as IEnumerable<Rover>);
        
        // Create an array that includes Probes (Satellites and Rovers)
        var probes = new Object[] {lunokhod, apollo, sojourner, sputnik};
        foreach (var probe  in probes)
        {
            Console.WriteLine($"Tracking a {probe.GetType()}");
        }
        
        /*
         *  Section 2: Upcasting Polymorphism.
         *  This wil use an overloaded version of DirectAll()
         */
        var iProbes = new IDirectable[] {lunokhod, apollo, sojourner, sputnik};
        DirectAll(iProbes as IEnumerable<IDirectable>);
        
    }

    private static void DirectAll(IEnumerable<Rover> rovers)
    {
        foreach (var rover in rovers)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine(rover.GetInfo());
            Console.WriteLine(rover.Explore());
            Console.WriteLine(rover.Collect());
        }
        Console.WriteLine("---------------------------------");
    }
    
    // Overload
    private static void DirectAll(IEnumerable<IDirectable> rovers)
    {
        foreach (var rover in rovers)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine(rover.GetInfo());
            Console.WriteLine(rover.Explore());
            Console.WriteLine(rover.Collect());
        }
        Console.WriteLine("---------------------------------");
    }
}