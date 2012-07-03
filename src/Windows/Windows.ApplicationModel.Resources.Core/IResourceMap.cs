using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[ExclusiveTo(typeof(ResourceMap)), Guid(1915242532u, 56204, 17144, 176, 140, 83, 255, 53, 125, 173, 130), Version(100794368u)]
	internal interface IResourceMap : IMapView<string, NamedResource>, IIterable<IKeyValuePair<string, NamedResource>>
	{
		Uri Uri
		{
			get;
		}
		[Overload("GetValue")]
		ResourceCandidate GetValue([In] string resource);
		[Overload("GetValueForContext")]
		ResourceCandidate GetValue([In] string resource, [In] ResourceContext context);
		ResourceMap GetSubtree([In] string reference);
	}
}
