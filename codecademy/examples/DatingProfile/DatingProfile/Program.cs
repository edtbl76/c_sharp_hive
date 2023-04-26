using System;

namespace DatingProfile;

public static class Program
{
    public static void Main(string[] args)
    {
        var profile = new Profile(
            "Ed Mangini", 45, "Boston", "USA", "he/him");
        profile.Hobbies = new[]
        {
            "coding",
            "practicing martial arts",
            "coaching",
            "writing a technical blog"
        };
        Console.WriteLine(profile.ViewProfile());
        
    }
}