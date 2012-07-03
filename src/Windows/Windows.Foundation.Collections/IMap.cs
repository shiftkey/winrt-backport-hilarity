using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(1009329662u, 34073, 17857, 170, 121, 25, 123, 103, 24, 193, 193), Version(100794368u)]
	public interface IMap<K, V> : IIterable<IKeyValuePair<K, V>>
	{
		uint Size
		{
			get;
		}
		V Lookup([In] K key);
		bool HasKey([In] K key);
		IMapView<K, V> GetView();
		bool Insert([In] K key, [In] V value);
		void Remove([In] K key);
		void Clear();
	}
}
