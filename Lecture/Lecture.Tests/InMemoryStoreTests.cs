using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Lecture.Tests;
[TestClass]
public class InMemoryStorageTests
{
    [TestMethod]
    public void Save_GivenMockSavable_Success()
    {
        InMemoryStore store = new();
        MockThing mockThing = new("Inigo Montoya");
        store.Save(mockThing);
        //MockThing mockThing1 = (MockThing).
        Assert.AreEqual<string?>("Inigo Montoya", ((MockThing)store.Item!)?.Name);
        Assert.AreEqual<string?>("Inigo Montoya", store.Item?.ToText());
        Assert.AreEqual<ISavable?>(mockThing, store.Item); // Use this way
    }
}
