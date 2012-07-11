namespace Windows.Foundation.Collections
{
	public interface IKeyValuePair<K, V>
	{
		K Key { get; }
		V Value { get; }
	}

    internal class KeyValuePairShim<K,V> : IKeyValuePair<K,V>
    {
        public KeyValuePairShim(K key, V value)
        {
            Key = key;
            Value = value;
        }

        public K Key { get; private set; }
        public V Value { get; private set; }
    }
}
