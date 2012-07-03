using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(1494739795u, 20660, 18957, 179, 9, 101, 134, 43, 63, 29, 188), Version(100794368u)]
	public interface IObservableVector<T> : IVector<T>
	{
		event VectorChangedEventHandler<T> VectorChanged;
	}
}
