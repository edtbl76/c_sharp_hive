## Strings

In C#, String is equivalent to string. 

Technically speaking, `string` is a reference type. More specifically it is a class that represents text. It is a `value` that is stored as a collection of `char` objects. 

Since it is a class, it is a reference type. However, it has value-like behaviors
- A `string` reference will always point to the original object, so mutating one reference to a string won't affect other references. 
  - Strings are `immutable`! (They can't be changed after being created)
  - Any operation that appears to modify a string object actually returns a NEW string object. 
- Comparing strings w/ the equality operator ( `==` ) performs a value comparison (NOT referential)

### Null, Unassigned, String.Empty

In order to avoid `NullReferenceException` errors Microsoft recommends using `String.Empty` or `""`
- NOTE: Null OR empty strings can be verified using the static method `String.IsNullOrEmpty()`

