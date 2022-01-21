using System;

namespace Lecture;
public abstract class Thing : ISavable
{
    // Virtual keyword allows for Name to be overridden in inherited classes
    // Class itself must be abstract in order to use an abstract method
    public abstract string Name { get; set; }

    public Thing(string name)
    {
        Name = name;
    }

    public virtual string ToText()
    {
        return Name;
    }
}
