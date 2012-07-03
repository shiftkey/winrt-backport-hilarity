using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(1709124597u, 48953, 16821, 174, 188, 90, 157, 134, 94, 71, 43), Version(100794368u)]
	public interface IObservableMap<K, V> : IMap<K, V>
	{
		event MapChangedEventHandler<K, V> MapChanged;
	}
}
