using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[DualApiPartition(version = 100794368u), HasVariant, MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class MediaPropertySet : IMap<Guid, object>, IIterable<IKeyValuePair<Guid, object>>
	{
		public extern uint Size
		{
			get;
		}
		public extern object Lookup([In] Guid key);
		public extern bool HasKey([In] Guid key);
		public extern IMapView<Guid, object> GetView();
		public extern bool Insert([In] Guid key, [In] object value);
		public extern void Remove([In] Guid key);
		public extern void Clear();
		public extern IIterator<IKeyValuePair<Guid, object>> First();
	}
}
