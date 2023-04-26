// See https://aka.ms/new-console-template for more information
using System;

namespace MoneyMaker
{
    internal static class MainClass
    {
        public static void Main(string[] args)
        {
            
            // Coin Amounts
            const int dollar = 100;
            const int halfDollar = 50;
            const int quarter = 25;
            const int dime = 10;
            const int nickel = 5;

            Console.WriteLine("Welcome to the Money Maker!");
            Console.Write("Enter an amount (in cents) to convert to coins: ");
            var amountInCents = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"{amountInCents} cents is equal to ...");
            
            // Calculate Dollars 
            var dollars = Math.Floor(amountInCents / dollar);
            var remainder = amountInCents % dollar;
            
            // Calculate Half Dollar
            var halfDollars  = Math.Floor(remainder / halfDollar);
            remainder = remainder % halfDollar;
            
            // Calculate Quarters
            var quarters = Math.Floor(remainder / quarter);
            remainder = remainder % quarter;
            
            // Calculate Dimes
            var dimes = Math.Floor(remainder / dime);
            remainder = remainder % dime;
            
            // Calculate Nickels
            var nickels = Math.Floor(remainder / nickel);
            remainder = remainder % nickel;
            

            Console.WriteLine($"Dollars      : {dollars}");
            Console.WriteLine($"Half Dollars : {halfDollars}");
            Console.WriteLine($"Quarters     : {quarters}");
            Console.WriteLine($"Dimes        : {dimes}");
            Console.WriteLine($"Nickels      : {nickels}");
            Console.WriteLine($"Pennies      : {remainder}");
            


        }
    }
}