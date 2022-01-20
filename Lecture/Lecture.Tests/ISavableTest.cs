using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lecture.Tests;

[TestClass]
public class ISavableTest
{
    [TestMethod]
    public void SimpleSave_GivenPerson_PersonString()
    {
        Person person = new("Inigo");
        // Whenever using "AreEqual" should always specify the datatype <string> in this case
        Assert.AreEqual<string>("Name: Inigo; DateOfBirth: 1/1/0001", person.ToText);
    }

    [TestMethod]
    public void SimpleSave_GivenAThing_Sting()
    {
        ISavable thing = new Thing("Thing 1");
        Assert.AreEqual<string>("Name: Thing 1; ", thing.ToText());
    }
}

