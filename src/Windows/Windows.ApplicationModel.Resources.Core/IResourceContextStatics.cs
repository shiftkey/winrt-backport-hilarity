using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[ExclusiveTo(typeof(ResourceContext)), Guid(2562628972u, 25400, 19249, 153, 223, 178, 180, 66, 241, 113, 73), Version(100794368u)]
	internal interface IResourceContextStatics
	{
		ResourceContext CreateMatchingContext([In] IIterable<ResourceQualifier> result);
	}
}
