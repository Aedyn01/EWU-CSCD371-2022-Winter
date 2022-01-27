namespace Lecture
{
    public class InMemoryStore : IStore
    {
        public void Save(ISavable item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public ISavable? Item { get; private set; }
    }
}