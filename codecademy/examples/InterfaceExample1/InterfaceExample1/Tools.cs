using System;

namespace InterfaceExample1;

internal static class Tools
{
    private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    public static string GenerateLicensePlate()
    {
        var random = new Random();
        var licensePlate = "";
        for (var i = 0; i < 8; i++)
        {
            licensePlate += Chars[random.Next(Chars.Length)];
        }

        return licensePlate;
    }
}