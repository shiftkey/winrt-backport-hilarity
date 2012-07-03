namespace Windows.Foundation.Collections
{
	public interface IVectorChangedEventArgs
	{
		CollectionChange CollectionChange { get; }
        uint Index { get; }
	}
}
