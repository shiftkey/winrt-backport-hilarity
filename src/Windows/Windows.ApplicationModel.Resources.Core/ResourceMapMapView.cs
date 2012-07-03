using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResourceMapMapView : IMapView<string, ResourceMap>, IIterable<IKeyValuePair<string, ResourceMap>>
	{
		public extern uint Size
		{
			get;
		}
		public extern ResourceMap Lookup([In] string key);
		public extern bool HasKey([In] string key);
		public extern void Split(out IMapView<string, ResourceMap> first, out IMapView<string, ResourceMap> second);
		public extern IIterator<IKeyValuePair<string, ResourceMap>> First();
	}
}
