using System;

namespace Prosiak.Logic;

public class Piggy
{
    private string name;

    public Piggy(string name, DateTime DateOfBirth)
    {
        this.name = name;
        this.DateOfBirth = DateOfBirth;
    }

    public string Name { get => $"My name is: {name.ToUpper()}"; }
    public DateTime DateOfBirth { get; }

    public TimeSpan Age()
    {
        return DateTime.Today - DateOfBirth; 
    }
}
// expression body methods
// properties without backing field