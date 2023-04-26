# Lists

## Array Review / Drawbacks
- Limited Length
- You have to keep track of the no. of elements in the array using a separate index.
- You can only edit one element at a time. 

## Lists

Solve all of the limitations of an array. 

Characteristics
- sequential collection of values
- can hold references to have any type
- have an effective unlimited length
- automatically track the no of elements in the list
- they have methods that support working w/ multiple elements at once. 


```c#
List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };

citiesList.Add("New York City");
citiesList.Remove("Dubai");
citiesList.AddRange(new string[] {"Cairo", "Johannesburg"});
bool hasNewDelhi = citiesList.Contains("New Delhi");
foreach (string city in citiesList)
{
    Console.WriteLine(city);
}
```

### Object Initialization

```c#
// Basic Construction 
/*
    uses parenthesis and no values
    - Values are added afterwards via Add statements. 
*/ 
List<string> cities = new List<string>();
cities.Add("Boston");
cities.Add("Worcester");

/*
    Object Initialization
    
    uses curly braces and the values go in -between
*/
List<string> cities = new List<string> {"Boston", "Worcester"};
```

### Helpful Methods

#### General
- `Add(<value>)` adds the given value to the end of the list
- `Count` provides the number of elements in the list
- `Contains(<value>)` returns true if the provided value is in the list 
- `Remove(<value>)` removes the first occurence of value from the list and returns true. Returns false if value isn't present. 
- `Clear()` removes all elements from the list. 

#### Ranges
- `AddRange(collection)`, 
  - takes an array or list as an argument. 
  - Adds the values of the provided collection to the end of the list. 
  - Returns nothing.
- `InsertRange(int, collection)`
  - takes an int followed by an array/list as an argument
  - adds the values starting at the provided index at `int`
  - Returns Nothing
- `RemoveRange(int1, int2)`
  - int1 is the index from which to start removing elements
  - int2 is the number of elements to remove
  - Returns nothing
- `GetRange(int1, int2)`
  - int1 is the index of the first desired element
  - int2 is the number of elements we want to retrieve
  - returns a list of the same type containing the retrieved elements

```c#
List<string> places = new List<string> { "first", "second" };
 
places.AddRange(new string[] { "fifth", "sixth" });
// List is  "first", "second", "fifth", "sixth" ]
places.InsertRange(2, new string[] { "third", "fourth"});
// List is [ "first", "second", "third", "fourth", "fifth", "sixth" ]
places.RemoveRange(4, 2);
// List is [ "first", "second", "third", "fourth" ]
List<string> newPlaces = places.GetRange(0, 3);
// New list is [ "first", "second", "third" ]
```

## Generic Collections
The list class is in a group of classes called generic collections (`System.Collections.Generic`). They don't exists in the default set of `System` classes, so we have to make a reference of them:

```c#
using System.Collections.Generic;
```

Generic collections are data structures that are defined w/ a generic type. Each class is defined generally without a specific type in mind. When we make an actual instance, we define the specific type: 

```c#
List<string> citiesList = new List<string>();
List<Object> objects = new List<Object>();
```

It's like a set of general instructions. We can allow adding/removing of elements w/o specifying the type of element. 

The formal class name of lists is `List<T>` where `T` is a type parameter that represents a placeholder (i.e. some type that can be specified later). The generic instructions are provided in the generic `List<T>` class. 

Generics are powerful, because 
- without them we would have to make a list class for EVERY different data type, defining the same properties and methods for each list class. 
- Use a list containing Object types, List<Object> — Using Object means we can’t use any of the unique functionality of each type and it takes a lot of computing power to convert references to and from the Object type.
