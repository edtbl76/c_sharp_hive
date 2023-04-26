# C# Basics

## Basic Notes
C# is fast.
A software company called Raygun built their application using Node.js, a 
framework for JavaScript. When their app started to slow down, they switched to
 .NET, a framework for C#. Their performance skyrocketed. As CEO John Daniel  
puts it, “using the same size server, we were able to go from 1,000 requests 
per second…with Node.js, to 20,000 requests per second with .NET Core.” In other
words, they increased throughput by 2,000%.      


C# is popular
- typically one of the top 5 to ten most popular programming languages. 

## Getting/Reading Input
```c#
using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}
```

Code can be executed from the terminal:
```shell
dotnet run
```

## Comments

```c#
// Single Line Comment

/*
    Multiple 
    Line Comment
*/
```

## Data Types

Data Types tell us several things about a piece of data:
- how it can be stored
- what operations can be performed w/ it
- different methods it can be used with. 

| Type     | Description                                                  | Size (bytes)    | .NET type       | Range                                   |
|----------|--------------------------------------------------------------|-----------------|-----------------|-----------------------------------------|
| int      | Whole numbers                                                | 4               | System.Int32    | -2^31 -> (2^31) - 1                     |
| long     | Whole numbers                                                | 8               | System.Int64    | -2^63 -> (2^63) - 1                     |
| float    | floating-point numbers                                       | 4               | System.Single   | +/- 3.4 x 10^38                         |
| double   | Double precision (more accurate) <br/>floating point numbers | 8               | System.Double   | +/- 1.7 x 10^308                        |
| decimal  | Monetary values                                              | 16              | System.Decimal  | 28 significant figures                  |
| char     | Single character                                             | 2               | System.Char     | M/A                                     |
| bool     | Boolean                                                      | 1               | System.Boolean  | True/False                              |
| DateTime | Moments in Time                                              | 8               | System.DateTime | 0:0:0 01/01/0001 -> 23:59:59 12/31/9999 |
| string   | Sequence of characters                                       | 2 per character | System.String   | N/A                                     |


### Data Type Conversion (Casting) 

C# allows implicit conversion when moving to larger data types (i.e. where data loss isn't possible)

`Implicit Conversion`:  This happens automatically if no data will be lost in the conversion. This occurs when moving to a data type that is capable of representing a larger amount of information than the source data type. 
```c#
// This example works because we are moving from int -> double

int myInt = 3;
double myDouble = myInt; 
```


`Explicit Conversion`: requires a cast operator to convert one data type into another. 
```c#
// In this example, we must explicitly cast the types because we 
// are moving from double -> int. 

double myDouble = 3.2;
int myInt = (int)myDouble;
```

We can also convert data types using built-in methods such as:
`Convert.ToX()`, where X is String, Double etc. 
- `Convert.ToString()`, `Convert.ToDouble()`

Example:
```c#
using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      // Turn that answer into an int
      int faveNumber = Convert.ToInt32(Console.ReadLine());


    }
  }
}
```
This is a particularly good example, because it is the preferred (and one of the few) ways to convert a string to an integer, which is commonly performed when reading input. 

---

## Built-In Methods

`Math.Abs()`: finds the absolute value of a number

`Math.Sqrt()`: finds the square root of a number

`Math.Floor()`: Round the given double/decimal down to the nearest whole number

`Math.Min()`: returns the smaller of TWO numbers. 

## Text Manipulation
Example:

```c#
using System;

namespace MadTeaParty
{
  class Program
  {
    static void Main(string[] args)
    {
      string drink = "wine";
      string madTeaParty = $"\"Have some {drink},\" 
        the March Hare said in an encouraging tone. 
        \nAlice looked all round the table, but there was nothing on it but 
        tea.\n\"I don't see any {drink},\" she remarked.\n\"There isn't any,\" 
        said the March Hare.";

      int storyLength = madTeaParty.Length;
      string toFind = "March Hare";

      string findLowerCase = toFind.ToLower(); 
      int findMarchHare = madTeaParty.IndexOf(toFind);

      Console.WriteLine(madTeaParty.Substring(findMarchHare));
      Console.WriteLine($"This scene is {storyLength} long.\n");
      Console.WriteLine($"The term we're looking for is {toFind} and is located 
        at index {findMarchHare}.");

    }
  }
}

```

## Truth Table


| A     | B     | A && B |
|-------|-------|--------|
| True  | True  | True   |
| True  | False | False  |
| False | True  | False  |
| False | False | False  |

| A     | B     | A or B |
|-------|-------|--------|
| True  | True  | True   |
| True  | False | True   |
| False | True  | True   |
| False | False | False  |


| A     | NOT A |
|-------|-------|
| True  | False |
| False | True  |


##  Method Arguments
`method signature`: a method's name and parameter types in order

`arguments`: values passed to a method

`parameters`: values defined in a method. 
- method parameters can only be used in the method body. 
- method parameters can be optional as long as a default value is provided in the method signature. 

`method overloading`: A type of polymorphism where multiple methods can have the same name as long as they have different method signatures. 





### Optional Arguments

```c#
using System;

namespace OptionalParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
      VisitPlanets(3);
      VisitPlanets(4);
      VisitPlanets(5);
    }
    
    // providing a default argument makes it optional to pass it in.
    static void VisitPlanets(int numberOfPlanets=0)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}

```


### Named Arguments

```c#
using System;

namespace NamedArguments
{
  class Program
  {
    static void Main(string[] args)
    {
        // Only calling the named argument
      VisitPlanets(numberOfPlanets: 2);
      VisitPlanets(numberOfPlanets: 2, name: "Ed Mangini");
    }
    
    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}
```

## Out

This is a really cool feature of C# in terms of Method Output, that allows you to output an additional piece of information. 
- The `out` parameter must use the `out` keyword and its expected type
- The `out` parameter must be set to a value before the method ends. 

```c#
using System;

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string ageAsString = "102";
      string nameAsString = "Granny";
      
      int ageAsInt;
      bool outcome = Int32.TryParse(ageAsString, out ageAsInt);
      Console.WriteLine(outcome + " " + ageAsInt);

      int nameAsInt;
      bool outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
      Console.WriteLine(outcome2 + " " + nameAsInt);
    }    
	}
}
```
```c#
using System;

namespace UsingOut
{
  class Program
  {
    static void Main(string[] args)
    {
      // Here I'm calling the method. 
      // notice that I'm defining the out argument inside the call
      // itself. Flag has extremely brief scope until it is 
      // converted to the parameter inside the method. 
      string whisper = Whisper("GARRRR", out bool flag);
      Console.WriteLine(whisper);
    }    

    static string Whisper(string statement, out bool marker) {
      marker = true;
      return statement.ToLower();
    }
	}
}
```

## Alternate Expression

### Expression-bodied Definitions
This type of definition can only be used when a method contains a single expression. 


Before Expression
```c#
bool IsEven(int num)
{
    return num % 2 == 0;
}
```

After Expression
```c#
bool IsEven(int num) => num % 2 == 0;
```

Before Expression:
```c#
using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      Welcome("Earth");
      double days = 500;
      double rotations = DaysToRotations(days);
      Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
    } 
    
    static double DaysToRotations(double days)
    {
      return days / 365;
    }
    
    static void Welcome(string planet)
    {
      Console.WriteLine($"Welcome to {planet}!");
    }
  }
}
```

After Expression
```c#
using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      Welcome("Earth");
      double days = 500;
      double rotations = DaysToRotations(days);
      Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
    } 
    
    static double DaysToRotations(double days) => days / 365;
    
    static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!");
  }
}
```

## Higher-Order Functions
```c#
public static bool IsLong(string word) => word.Length > 8;

static void Main(string[] args) {
    string[] adjectives = {"rocky", "mountainous", "cosmic"};
    
    // Higher Order Function
    string firstLongAdjective = Array.Find(adjectives, IsLong);
    
}
```

## Lambda

```c#
string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
static bool HitGround(string s) => s == "meteorite";

// Pre-Lambda
bool makesContact = Array.Exist(spaceRocks, HitGround);

// Lambda
bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");

// Lambda shortcut
bool makesContact = Array.Exists(spaceRocks, s => == "meteorite");
```

## Arrays

```c#
summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", 
"New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
```

### Helpful Methods
`Array.IndexOf(<array>, <element>)`
```c#
int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
int index = Array.IndexOf(ratings, 3);  // Will have index of 3
```

`Array.Find(<array>, <function/lambda>)`
```c#
summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

 var longSong = Array.Find(summerStrut, song => song.Length > 10);
 Console.WriteLine($"The first song that has more than 10 characters in the title is {longSong}");
 
```

`Array.Sort(array)`
Just like java. 

`Array.Reverse(array)`
- self-explanatory

`Array.Copy()`
```c#
string[] summerStrut;
      
summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

// You have to initialize string arrays w/ length and new keyword
string[] summerStrutCopy = new String[8];

// You always have to specify the length as a parameter...
Array.Copy(summerStrut, summerStrutCopy, 8);
Console.WriteLine(summerStrutCopy[0]);
```

## LOOPS

### Foreach syntax
```c#
foreach (string str in strings) {
    // do the needful
}
```