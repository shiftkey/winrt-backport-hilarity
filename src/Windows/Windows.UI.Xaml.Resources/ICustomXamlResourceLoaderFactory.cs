using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Resources
{
	[ExclusiveTo(typeof(CustomXamlResourceLoader)), Guid(1543339593u, 30854, 17651, 142, 211, 111, 236, 4, 99, 237, 105), Version(100794368u), WebHostHidden]
	internal interface ICustomXamlResourceLoaderFactory
	{
		CustomXamlResourceLoader CreateInstance([In] object outer, out object inner);
	}
}
