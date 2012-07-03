using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DependencyProperty)), Guid(1239806607u, 33369, 19804, 170, 224, 131, 213, 109, 187, 104, 217), Version(100794368u), WebHostHidden]
	internal interface IDependencyPropertyStatics
	{
		object UnsetValue
		{
			get;
		}
		DependencyProperty Register([In] string name, [In] TypeName propertyType, [In] TypeName ownerType, [In] PropertyMetadata typeMetadata);
		DependencyProperty RegisterAttached([In] string name, [In] TypeName propertyType, [In] TypeName ownerType, [In] PropertyMetadata defaultMetadata);
	}
}
