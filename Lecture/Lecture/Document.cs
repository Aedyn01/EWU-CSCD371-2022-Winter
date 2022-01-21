using System;
using System.Runtime.Serialization;

namespace Lecture;
public class Document : Thing, ISavable, ISerializable
{
    public string Content { get; private set; }
    // public string Name { get; private set; }

    public Document(string name) => Name = name;

    // Can have two types of same name when using an interface
    // Call the ISavable version by casting (ISavable
    string ISavable.ToText()
    {
        string text = "Inigo Montoya";
        // Bad api for ToUpper, it returns a SEPERATE string, does not alter the original one
        // text.ToUpper();
        // Must set like this
        text = text.ToUpper();
        return $"{nameof(Name)}: {Name}" + text;
    }

    public string ToText()
    {
        return Content;
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
        throw new NotImplementedException();
    }
}
