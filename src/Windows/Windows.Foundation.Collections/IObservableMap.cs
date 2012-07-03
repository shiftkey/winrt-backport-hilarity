namespace Windows.Foundation.Collections
{
	public interface IObservableMap<K, V> : IMap<K, V>
	{
		event MapChangedEventHandler<K, V> MapChanged;
	}
}
