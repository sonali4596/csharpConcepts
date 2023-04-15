/**
1.Why Properties ?
exposing the class fields to the outer world we are allowing people to have full control over the variables. which is not good for business.
so we should encapsulate and by making the field private or protected and use getter and setter method to allow people to set or get the variable.

2.What are properties ?
properties are a variable with get and set method.
shotcut key to create property is type "prop" and hit enter.

3.Four types of properties :
    1. read-only property  has only get accessor method
    2. write-only property.  has only set accessor  method
    3. read-write property.  have both getter and setter both accessor method
    4. auto implemented properties  no customisation to get and setter property

4.Unlike fields properties aren't classified as variables hence they can't be passed as ref and out parameter.
5.The value keyword is used to define the value being assigned by the set or init accessor.

6.Properties with backing fields

One basic pattern for implementing a property involves using a private backing field for setting and retrieving the property value. 
The get accessor returns the value of the private field, and the set accessor may perform some data validation before assigning a value to 
the private field.Both accessors may also perform some conversion or computation on the data before it's stored or returned

7.Expression body definitions
    1.=> is used to get or set the value.
    2.Both the get and the set accessor can be implemented as expression-bodied members. In this case, the get and set keywords must be present.


**/

public class Person
{
    private string _firstName;
    private string _lastName;

    public Person(string first, string last)
    {
        _firstName = first;
        _lastName = last;
    }

    public string Name => $"{_firstName} {_lastName}";
}

public class SaleItem
{
    string _name;
    decimal _cost;

    public SaleItem(string name, decimal cost)
    {
        _name = name;
        _cost = cost;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public decimal Price
    {
        get => _cost;
        set => _cost = value;
    }
}
