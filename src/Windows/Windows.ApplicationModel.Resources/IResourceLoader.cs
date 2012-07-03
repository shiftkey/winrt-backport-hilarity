using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources
{
	[ExclusiveTo(typeof(ResourceLoader)), Guid(139610376u, 5871, 17837, 166, 2, 41, 54, 55, 215, 230, 26), Version(100794368u)]
	internal interface IResourceLoader
	{
		string GetString([In] string resource);
	}
}
