using System;

namespace  MagicalInheritance;

internal static class Program
{
    public static void Main(string[] args)
    {
        var pupil = new Pupil("Raistlin");
        var windStorm = pupil.CastWindStorm();
        Console.WriteLine(windStorm.Announce());

        var mage = new Mage("Fistandantilus");
        var rainStorm = mage.CastRainStorm();
        Console.WriteLine(rainStorm.Announce());

        var archmage = new ArchMage("Gandalf");
        var strongRainStorm = archmage.CastRainStorm();
        var lightningStorm = archmage.CastLightningStorm();
        Console.WriteLine(strongRainStorm.Announce());
        Console.WriteLine(lightningStorm.Announce());

    }
}