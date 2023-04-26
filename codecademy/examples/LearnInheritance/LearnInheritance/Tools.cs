using System;

namespace LearnInheritance
{
    internal static class Tools
    {
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string GenerateLicensePlate()
        {
            var rand = new Random();
            var licensePlate = "";
            for (var i = 0; i < 8; i++)
            {
                licensePlate += Chars[rand.Next(Chars.Length)];
            }
            return licensePlate;
        }
    }
}