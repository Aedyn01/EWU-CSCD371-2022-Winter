using System;

namespace Lecture.Tests;
public class Thing
{
    public string Name { get; set; }

    public Thing(string name)
    {
        Name = name;
    }

    public string ToText()
    {
        return Name;
    }
}
