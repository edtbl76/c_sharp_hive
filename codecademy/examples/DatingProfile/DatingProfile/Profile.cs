using System;

namespace DatingProfile;

public class Profile
{
    private readonly string _name;
    private readonly int _age;
    private readonly string _city;
    private readonly string _country;
    private readonly string _pronouns;
    private string[]? _hobbies;

    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
        _name = name;
        _age = age;
        _city = city;
        _country = country;
        _pronouns = pronouns;
        Hobbies = Array.Empty<string>();
        
    }
    
    
    // Properties
    public string[]? Hobbies
    {
        get => _hobbies;
        set => _hobbies = value ?? throw new ArgumentNullException(nameof(value));
    }

    // Methods
    public string ViewProfile()
    {
        var bio = $"Name     : {_name}\n" +
                  $"Age      : {_age}\n" +
                  $"City     : {_city}\n" +
                  $"Country  : {_country}\n" +
                  $"Pronouns : {_pronouns}\n";


        // Short Circuit
        if (Hobbies is not {Length: > 0}) return bio;
        
        // LINQ Expression 
        var hobbyString = Hobbies.Aggregate($"Hobbies  :\n", (current, hobby) => current + $" - {hobby}\n");

        return bio + hobbyString;

    }
}