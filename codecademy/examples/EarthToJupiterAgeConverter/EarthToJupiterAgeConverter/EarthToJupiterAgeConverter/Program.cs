// See https://aka.ms/new-console-template for more information

namespace EarthToJupiterAgeConverter
{
    internal static class PlanetConverter
    {
        private static void Main(string[] args)
        {
            // My Age
            const int myAge = 45;
            
            // Length of Years On Jupiter (in Earth Years) 
            const double jupiterYears = 11.86;
            
            // Time to Fly to Jupiter (in Earth Years) 
            const double timeToJupiter = 6.142466;
            
            // Age Conversions
            const double jupiterAge = myAge / jupiterYears;
            const double earthAgeAfterTrip = myAge + timeToJupiter;
            const double jupiterAgeAfterTrip = earthAgeAfterTrip / jupiterYears;
            
            Console.WriteLine("Current Earth Age                   : " + myAge);
            Console.WriteLine("Current Jupiter Age                 : " + jupiterAge);
            Console.WriteLine("Earth Age After Flying To Jupiter   : " + earthAgeAfterTrip);
            Console.WriteLine("Jupiter Age After Flying To Jupiter : " + jupiterAgeAfterTrip);
        }
    }
}