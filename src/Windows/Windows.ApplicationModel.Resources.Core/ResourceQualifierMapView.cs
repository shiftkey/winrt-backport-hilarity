using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResourceQualifierMapView : IMapView<string, string>, IIterable<IKeyValuePair<string, string>>
	{
		public extern uint Size
		{
			get;
		}
		public extern string Lookup([In] string key);
		public extern bool HasKey([In] string key);
		public extern void Split(out IMapView<string, string> first, out IMapView<string, string> second);
		public extern IIterator<IKeyValuePair<string, string>> First();
	}
}
