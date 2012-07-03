using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResourceQualifierObservableMap : IObservableMap<string, string>, IMap<string, string>, IIterable<IKeyValuePair<string, string>>
	{
		public extern event MapChangedEventHandler<string, string> MapChanged
		{
			add;
			remove;
		}
		public extern uint Size
		{
			get;
		}
		public extern string Lookup([In] string key);
		public extern bool HasKey([In] string key);
		public extern IMapView<string, string> GetView();
		public extern bool Insert([In] string key, [In] string value);
		public extern void Remove([In] string key);
		public extern void Clear();
		public extern IIterator<IKeyValuePair<string, string>> First();
	}
}
