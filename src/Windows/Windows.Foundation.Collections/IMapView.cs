namespace Windows.Foundation.Collections
{
	public interface IMapView<K, V> : IIterable<IKeyValuePair<K, V>>
	{
		uint Size { get; }
		V Lookup(K key);
		bool HasKey(K key);
		void Split(out IMapView<K, V> first, out IMapView<K, V> second);
	}
}
