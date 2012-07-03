using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(3833646656u, 41784, 19162, 173, 207, 39, 34, 114, 228, 140, 185), Version(100794368u)]
	public interface IMapView<K, V> : IIterable<IKeyValuePair<K, V>>
	{
		uint Size
		{
			get;
		}
		V Lookup([In] K key);
		bool HasKey([In] K key);
		void Split(out IMapView<K, V> first, out IMapView<K, V> second);
	}
}
