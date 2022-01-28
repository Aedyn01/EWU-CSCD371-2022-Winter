namespace Lecture.Tests;

[TestClass]
public class PersonTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Name_ConstructorNameIsNull_ThrowException()
    {
        new Person(null!);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Name_GivenNameIsNull_ThrowException()
    {
        Person person = new("Inigo Montoya");
        person.Name = null!;
    }

    [TestMethod]
    public void Equality_TwoStrings_AreEqual()
    {
        string dateTime = DateTime.Now.ToString();
        Person person1 = new($"Inigo Montoya {dateTime}");
        Person person2 = new($"Inigo Montoya {dateTime}");
        // person1.Equals

        // Assert.AreEqual(person1, person2);
        Assert.IsTrue(person1 == person2);
    }

    [TestMethod]
    public void Equality_TwoStrings_AreEqual()
    {
        string dateTime = DateTime.Now.ToString();
        Person person1 = new($"Inigo Montoya {dateTime}");
        Person person2 = new($"Inigo Montoya {dateTime}");
        Assert.IsTrue(person1 == person2.);
    }
}

