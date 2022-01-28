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
        // Can use either of these to cast back to a MockThing
        Assert.AreEqual<string?>("Inigo Montoya", (store.Item as MockThing)?.Name);
        Assert.AreEqual<string?>("Inigo Montoya", ((MockThing)store.Item!)?.Name);
        // Using store.Item?.ToText() says that
        // "if store.Item is null, then DO NOT call ToText()"
        Assert.AreEqual<string?>("Inigo Montoya", store.Item?.ToText());
        Assert.AreEqual<ISavable?>(mockThing, store.Item); // Use this way
    }
}
