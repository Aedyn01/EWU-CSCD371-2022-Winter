namespace Lecture8Generics
{
    // What this says is that we are creating a class,
    // and to create this class we naeed to pass in these two values
    // Can add a "where" clause to enforce that a key cant be null
     
    public class Dictionary<TKey,TValue> 
        where TKey : notnull 
        where TValue : class
    {
        private List<KeyValuePair<TKey,TValue>> _List = new();
        public void Add(TKey key,TValue value)
        {
            _List.Add(new KeyValuePair<TKey,TValue>(key, value));
        }

        public TValue Get(TKey key)
        {
            foreach(var kvp in _List)
            {
                if(key.Equals(kvp.Key))
                {
                    return kvp.Value;
                }
            }
            throw new KeyNotFoundException($"{key} not in dictionary");
        }

        public bool KeyExists(TKey key)
        {
            foreach (var kvp in _List)
            {
                if (key.Equals(kvp))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
