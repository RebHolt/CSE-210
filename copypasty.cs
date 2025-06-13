
using System.Collections.Generic;




static void Main(string[] args)
{

    Person p1 = new Person();
    Person p2 = new Person("Jane", "Doe");
    Person p3 = new Person("Mrs.", "Jane", "Doe");

}

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public string GetFirstName()
    {
        return _firstName;
    }
    public string SetFirstName(string firstname)
    {
        _firstName = firstname;
    }
}


// public string GetInformalSignature()
// {
//     return $"Thanks, {_firstName}";
// }
// public string GetFormalSignature()
// {
//     return $"Sincerely, {GetFullName}";
// }
// public string GetFullName()
// {
//     return $"{_title} {_firstName} {_lastName}";
// }

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public Person()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";

    }
    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }
    public Person(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }
}


