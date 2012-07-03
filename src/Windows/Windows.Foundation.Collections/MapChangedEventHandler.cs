using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	public delegate void MapChangedEventHandler<K, V>([In] IObservableMap<K, V> sender, [In] IMapChangedEventArgs<K> @event);
}
