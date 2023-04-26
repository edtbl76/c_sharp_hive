# OOP

## Terms
`Class` custom data type

`Instance` a single object created based on the definition of a class. 

`Object` the result of instantiating a class. 

`Encapsulation` the OOP concept of bundling related data and methods, making code easier to organize and reuse. 


## Properties

```c#
public string size;
public string Size
{
  get { return size; }
  set { size = value; }
}
```

### Expression Body
```c#
public string size; 
public String Size 
{
    get => age;
    set => age = value;
}
```

### Automatic Properties
Since the basic getter/setter pattern (i.e no validations) is so common, it can be written in shorthand. 
```c#
public string Size
{ get; set; }
```

### Static Members
A `static` field and/or property is one that applies to ALL instances of an object. These fields/properties represent data that should be shared by all instances. 

### Static Classes
A static class can't be instantiated, so it tends to be used for utilities or tools. We don't need new instances because they don't store new infomration. 

---

## Interfaces
`interface` Is a set of properties, methods and other members that represents a group of interactions. They are declared w/ a signature, but their behaviors aren't defined. 

A class `implements` an interface if it defines those properties, methods and other members.

Interface Example
```c#
using System;

namespace LearnInterfaces
{
  interface IAutomobile {
    string LicensePlate { get; }
    double Speed { get; }
    int Wheels { get; }
    void Honk();
  }
}
```

Implementation Example
```c#
using System;

namespace LearnInterfaces
{
  class Sedan : IAutomobile {
    public string LicensePlate { get; }
    public double Speed { get; }
    public int Wheels { get; }

    public void Honk() {
      Console.WriteLine("Beep Beep!");
    }
  }
}
```

## Inheritance

PROBLEM:
- Sometimes we have to solve the same problem over and over. It doesn't make sense for us to make the same change on code across multiple files. (i.e. individually)
  - Huge waste of time. 
  - there's a chance that we won't make the change properly in every file, leading to variance and errors. 

SOLUTION:
- Inheritance provides a good solution to this problem by providing a super class with generic solutions to some of the shared problems, which can be `inherited` by the subclasses. 


### Protected
Members can be marked `protected` in the super class which allows them to be accessed by subclasses (which isn't allowed by default private)


### Override vs. New
In order to hide/override a method from a super class you have two options

`new`: 
```c#
public new void Method() {
    // Do the thing
}
```
- The pro is that you only have to modify the subclass method. 
- The con is that it is very vague what is happening.


`override`
```c#
// subclass
public override void Method() {
    // Do the new thing
}

// superclass
public virtual void Method() {
    // Do the default thing
}
```
- The pro is that this is very explicit
- The con is that it requires code changes to both classes. 

### Making Inherited Members Abstract
In some cases a superclass will define a method that will be different for 
every subclass. In these cases, there isn't any need to define a default
implementation. We also want to set a constraint that an implementation is 
defined in every subclass. Here, we can define a method explicitly as
`abstract`

This tells implementing subclasses: 
- if you inherit from me, you MUST define abstract methods, because I haven't
defined a default impl for you to inherit... bitches. 

---

## References
Classes are `reference types` which means that when we create a new instance of a class and store it in a variable, the variable is to a `reference` of the object. 
```c#
Dissertation diss = new Dissertation();
```
- a new `Dissertation` instance is constructed and stored in the computer's memory. 
- a slot in the computer's memory is holding the instance's type, property values, etc. 
- `diss` is  not an object, it is a `reference` to that location in memory.
- an object may have multiple references

```c#
Dissertation anotherDiss = diss;
```

Now there are two references to the same location in memory: we can say that diss1 and diss2 refer to the same object. If changes are made to that object, then they will be reflected in both references to it:

```c#
Dissertation diss1 = new Dissertation();
Dissertation diss2 = diss1;
diss1.CurrentPage = 0;
diss2.CurrentPage = 16;
Console.WriteLine(diss1.CurrentPage);
Console.WriteLine(diss2.CurrentPage);
```

- The middle two lines of this code are setting the CurrentPage property of the same object (first setting it to 0, then 16)
- The last two lines will print the same value, 16

### Ref vs. Value
`value types`: hold the actual data. Every primitive type is a value type
- int
- double
- bool
- char

`reference types`: refer to a place in memory


```c#
// 2 different reference types that refer to the same memory location
Book bookLocation = new Book();
Book sameBookLocation = bookLocation;

// The initial value is COPIED to a NEW location in memory
bool falseValue = false;
bool anotherFalseValue = falseValue;
```

In pass-by-reference cases, a modification is changing "data at this location", which means that the mutation is visible to all references pointing at that memory location. 

In pass-by-value cases, each variable contains a value that is stored at a separate location, allowing mutations to one variable to be benign to the other. 

### Comparisons

#### Value Comparison
Performed when comparing `value types`, which means that we are testing to make sure that both variables in the comparison have the same VALUE
```c#
var int1 = 6;
var int2 = 6;
Console.WriteLine(int1 == int2);  //Output: true
```

#### Referential Comparison
This is when comparing `reference types`, which means that we are testing to ensure that both variables point to the same location in memory. This is important, because two variables can have the same value stored in separate memory locations. 
```c#
Dissertation d1 = new Dissertation(50);
Dissertation d2 = new Dissertation(50);
Console.WriteLine(d1 == d2); // Output: False. 
```

### References of Different Types
In a prior example, both references to the `Dissertation` object were of type `Dissertation`
```c#
Dissertation d1 = new Dissertation();
Dissertation d2 = d1;
```

When we use `d1` and `d2`, we can handle the `Dissertation` object as an object of that type. However, Dissertation extends `Book` and implements `IFlippable`, so it can be referenced that way as well. 
```c#
Dissertation d1 = new Dissertation(50);
IFlippable fdiss = diss;
```

Both variables reference the same object, but since the second variable is an `IFlippable` reference it can ONLY use functionality provided by that type. 
```c#
Dissertation d1 = new Dissertation(50);
IFlippable id2 = d1;

// This is ok, because both types define Flip()
d1.Flip();
id2.Flip();

// This will throw an error for the second statement, because IFlippable
// doesn't know what Define() is.
Console.WriteLine(d1.Define());
Console.WriteLine(id2.Define());

// Same situation with book. 
Book book = d1;

// Book and Diss. both define Title
Console.WriteLine(d1.Title);
Console.WriteLine(book.Title);

// We get hung up on Define again.
book.Define()   // <-- Error
```


### Arrays of References

We can use inherited classes/implemented interfaces to reference an object
```c#
Dissertation diss = new Dissertation(50);
IFlippable fdiss = diss;
```

This allows us to work w/ many similar types at the same time. 
```c#
Diary diary1 = new Diary(1);
Diary diary2 = new Diary(30);

Dissertation diss1 = new Dissertation(50);
Dissertation diss2 = new Dissertation(49);

diary1.Flip();
diary2.Flip();
diss1.Flip();
diss2.Flip();
```

That's kind of a monstrosity to look at. It is **faster** and **safer** to store the refs in an array and loop through it. Selecting the appropriate type depends on the common denominator (in this case, `IFlippable`)
```c#
// Adjustment for visual reference... pre Array
IFlippable f1 = new Diary(1);
IFlippable f2 = new Diary(30);
IFlippable f3 = new Dissertation(50);
IFlippable f4 = new Dissertation(49);

// ... Post array
IFlippable[] classroom = new IFlippable[] { new Diary(1), new Diary(30),
    new Dissertation(50), new Dissertation(49) };
    
foreach (IFlippable f in classroom) {
    f.Flip();
}
```

## Polymorphism
This is a common concept (part of OOP) across many programming languages, where the same interface can be used for multiple data types. 
A programming supports polymorphism if:

1. Objects of different types have a common interface 
   1. (I'm referring to interface generically... not just an `interface`)
2. The objects can maintain functionality unique to their data type. 

```c#
/*
    Given a super class and a subclass w/ an overloaded method...
*/
class Dissertation : Book
{
  public override string Stringify()
  {
    return "This is a Dissertation object!";
  }
}
 
 
class Book
{
  public virtual string Stringify()
  {
    return "This is a Book object!";
  }
}

// What will this print?
Book book = new Book();
Book dissertation = new Dissertation();
Console.WriteLine(book.Stringify());
Console.WriteLine(dissertation.Stringify());

/*
    OUTPUT:
        This is a Book object!
        This is a Dissertation object!
*/
```
- Both of the variables are `Book` type references, but their behavior is
different. 
  - Dissertation overrides Stringify(), so all Dissertation objects (regardless of reference type) will use that method. 
  - ("regardless of reference type") -> This is why we can use `var`

SHORT VERSION:
`polymorphism` is the ability in programming to present the same interface for differing data types. 


## Casting

We've referred to objects via `upcasting`, i.e. w/ a reference of
- their own type
- an inherited type
- an implemented interface


`downcasting` is the process of trying to reference an object by its subclass. This is necessary when yuo want to access the specific functionality of a subclass. 
```c#
Book bk = new Book();
Dissertation dbk = bk;
// Error!
```
Not every downcast is compatible. To get around this, we have to explicitly downcast
```c#
Book book = new Book();
Dissertation dissertation = (Dissertation)book;
```

This can still cause failures that require the use of special `as` or `is` operators. 

### Summary

`upcasting` is creating a superclass or interface reference from a subclass reference. Upcasting can be implicit.

`downcasting` is creating a subclass reference from a superclass or interface reference. Downcasting needs to be explicit.

## Null/Unassigned Reference

```c#
// Null Reference
Diary diary = null;

// Unassigned reference
Diary diary;

// Unassigned Array reference (the elements are unassigned) 
Diary[] diaries = new Diary[5];
```

Null references can only be compared if explicitly labeled as null
```c#
Diary diary = null;
Console.WriteLine(diary == null);
// True

Diary diary2;
Console.WriteLine(diary2 == null);
// False
```


## Object class
- Every class is derived from Object. It is at the very top of the inheritance hierarchy

### Useful Members
- `Equals(Object)`: returns true if the current instance and the argument are equal (using `value` equality for value types and `referential` equality for reference types)
- `GetType()`: returns the ty pe of the object
- `ToString()`: returns a string describing the objecvt.

```c#
Object object1 = new Object();
// t is System.Object
Type t = object1.GetType();

string s = object1.ToString();
// Prints System.Object
Console.WriteLine(s);

Object object2 = object1;
bool b = object1.Equals(object1);
```