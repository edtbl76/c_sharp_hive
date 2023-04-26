namespace ClassesExample2; 

public class Forest
{
    private readonly string _biome;
    
    // Constructors
    /*
     *  Rather than overloading this constructor, I can provide an optional parameter
     *  for the biome property.
     
     */
    public Forest(string name, string biome = "Unknown")
    {
        this.Name = name;
        this._biome = biome;
        this.Biome = biome;
        Age = 0;
    }
    
    // Method 
    public int Grow()
    {
        Trees += 30;
        Age += 1;
        return Trees;
    }

    public int Burn()
    {
        Trees -= 20;
        Age += 1;
        return Trees;
    }
    
    // automatic property
    public string? Name { get; set; }
    
    // automatic property
    public int Trees { get; set; }

    // private setter, can't be accessed outside this class 
    /*
     *  Note: I'm using the expression body, rather than the
     *  
     */
    public int Age { get; private set; }

    public string Biome
    {
        get => _biome;
        /*
         * Converted to ternary operator w/ logical expression. 
         */
        private init => _biome = value is "Tropical" or "Temperate" or "Boreal" ? value : "Unknown";
    }
}