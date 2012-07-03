using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources
{
	[ExclusiveTo(typeof(ResourceLoader)), Guid(3275372035u, 27100, 17029, 160, 119, 213, 192, 228, 124, 203, 232), Version(100794368u)]
	internal interface IResourceLoaderFactory
	{
		ResourceLoader CreateResourceLoaderByName([In] string name);
	}
}
