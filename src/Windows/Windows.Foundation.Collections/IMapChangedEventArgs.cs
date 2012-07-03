namespace Windows.Foundation.Collections
{
	public interface IMapChangedEventArgs<K>
	{
		CollectionChange CollectionChange { get; }
		K Key { get; }
	}
}
