# Linq

## Questions about manipulating collections of entities from a database. 

- How do you access all of them? 
- How do you apply filters? 
- What if you need to format attributes of each instance? 

### Solution W/ Lists
- Store each entity in a list and iterate through that list w/ a `foreach` loop. 
- This would require nesting if statements and storing each result in a new list. 
- Fugly. 

## LINQ
- works for complex selections and transformations
- works on local/remote data sources

A `query` is each one of those selections/transformations. 

### Var
- Every Linq query returns either a single value or an object of type `IEnumerable<T>`. 
  - It works w/ `foreach` loops just like arrays and lists
  - you can determine it's length w/ `Count()`
- Singe the single value type (and/or parameter) type `T` isn't always knowon, it's common to store a query's returned value in a variable of type `var`.
  - `var` is just an implicitly typed variable, determined by the C# compiler. 


```c#
string[] names = {"Bruce", "Clark", "Diana"};
var shortNames = names.Where(n => n.Length < 4);
```

### Helpful Operators
- `select/Select()`
  - this determines what is returned for each element in the sequence
  - (this is a map)
- `where/Where()`
  - picks elements from the sequence that satisfy the given condition. 
  - The condition is normally written like the condition expressions you would find in an if statement. 
  - (This is a filter)
- `from`
  - declares a variable to iterate through the provided sequence


`from` and `select` are required, `where` is optional.
(NOTE: from is not used in method syntax)


## Method Syntax Vs. Query Syntax

Query Syntax has the look and feel of blocks of multiline SQL
```c#
var longLoudHeroes = 
    from h in heroes
    where h.Length > 6
    select h.ToUpper();
```

Method Syntax looks like plain old code
- One of the advantages is that I can use Where on its if I ony need to filter out values. 
```c#
// Separate Statements
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());


// Chaining
var longLoudHeroes = heroes
    .Where(h => h.Length > 6)
    .Select(h => h.ToUpper());
```

### Which to use? 
- Microsoft recommends
  - For single operator queries, use method syntax
  - use query syntax for everything else. 

### Count and Count()
- `Count` is an attribute of a `List` that tracks the number of elements in the collection
- `Count()` is a Linq utility method that gets the number of elements in the current query result set.  