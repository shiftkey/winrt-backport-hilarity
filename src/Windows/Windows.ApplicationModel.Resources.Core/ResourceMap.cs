using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResourceMap : IResourceMap, IMapView<string, NamedResource>, IIterable<IKeyValuePair<string, NamedResource>>
	{
		public extern Uri Uri
		{
			get;
		}
		public extern uint Size
		{
			get;
		}
		[Overload("GetValue")]
		public extern ResourceCandidate GetValue([In] string resource);
		[Overload("GetValueForContext")]
		public extern ResourceCandidate GetValue([In] string resource, [In] ResourceContext context);
		public extern ResourceMap GetSubtree([In] string reference);
		public extern NamedResource Lookup([In] string key);
		public extern bool HasKey([In] string key);
		public extern void Split(out IMapView<string, NamedResource> first, out IMapView<string, NamedResource> second);
		public extern IIterator<IKeyValuePair<string, NamedResource>> First();
	}
}
