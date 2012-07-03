using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(395646963u, 38126, 16888, 189, 220, 118, 138, 137, 85, 68, 243), Version(100794368u)]
	public delegate void MapChangedEventHandler<K, V>([In] IObservableMap<K, V> sender, [In] IMapChangedEventArgs<K> @event);
}
