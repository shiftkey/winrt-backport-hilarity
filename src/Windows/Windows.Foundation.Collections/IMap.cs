using System.Runtime.InteropServices;

namespace Windows.Foundation.Collections
{
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
