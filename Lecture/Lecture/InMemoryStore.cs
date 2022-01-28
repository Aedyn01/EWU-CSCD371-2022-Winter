namespace Lecture
{
    public class InMemoryStore : IStore
    {
        public void Save(ISavable item)
        {
            // ?? is a null coalesce operator, says that
            // "if this is null, throw this exception"
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public ISavable? Item { get; private set; }
    }
}