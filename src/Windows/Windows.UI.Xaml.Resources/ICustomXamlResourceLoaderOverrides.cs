using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Resources
{
	[ExclusiveTo(typeof(CustomXamlResourceLoader)), Guid(4166117777u, 44802, 18152, 154, 248, 66, 123, 126, 191, 233, 248), Version(100794368u), WebHostHidden]
	internal interface ICustomXamlResourceLoaderOverrides
	{
		object GetResource([In] string resourceId, [In] string objectType, [In] string propertyName, [In] string propertyType);
	}
}
