namespace ClassesExample3;

public class Forest
{

    // FIELDS
    private readonly string? _biome;

    // CONSTRUCTORS
    static Forest()
    {
        TreeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate." +
                    "\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
        ForestsCreated = 0;
    }
    public Forest(string name, string? biome = "Unknown")
    {
        this.Name = name;
        this._biome = biome;
        this.Biome = biome;
        this.Age = 0;
        ForestsCreated++;
    }

    // METHODS
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

    public static void PrintTreeFacts()
    {
        Console.WriteLine(TreeFacts);
    }
    
    // PROPERTIES
    public int Trees { get; set; }

    public int Age { get; private set; }

    public string? Biome
    {
        get => _biome;
        private init => _biome = value is "Tropical" or "Temperate" or "Boreal" ? value : "Unknown";
    }

    public string? Name { get; set; }

    public static int ForestsCreated { get; private set; }
    
    /*
     *  Since the property is instantiated in the static constructor, it's unnecessary to
     * provide a private setter, and we can define this as a read-only/get-only auto property.
     */
    public static string? TreeFacts { get; }
}