namespace Windows.Foundation.Collections
{
	public interface IObservableVector<T> : IVector<T>
	{
		event VectorChangedEventHandler<T> VectorChanged;
	}
}
