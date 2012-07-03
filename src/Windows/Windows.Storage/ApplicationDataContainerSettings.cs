using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ApplicationDataContainerSettings : IPropertySet, IObservableMap<string, object>, IMap<string, object>, IIterable<IKeyValuePair<string, object>>
	{
		public extern event MapChangedEventHandler<string, object> MapChanged
		{
			add;
			remove;
		}
		public extern uint Size
		{
			get;
		}
		public extern object Lookup([In] string key);
		public extern bool HasKey([In] string key);
		public extern IMapView<string, object> GetView();
		public extern bool Insert([In] string key, [In] object value);
		public extern void Remove([In] string key);
		public extern void Clear();
		public extern IIterator<IKeyValuePair<string, object>> First();
	}
}
