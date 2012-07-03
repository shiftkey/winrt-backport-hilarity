using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources
{
	[ExclusiveTo(typeof(ResourceLoader)), Guid(3212279009u, 6600, 18882, 149, 60, 71, 233, 34, 123, 51, 78), Version(100794368u)]
	internal interface IResourceLoaderStatics
	{
		string GetStringForReference([In] Uri uri);
	}
}
