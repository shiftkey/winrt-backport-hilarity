using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(PropertyMetadata)), Guid(3250068672u, 22477, 20271, 176, 169, 225, 128, 27, 40, 247, 107), Version(100794368u), WebHostHidden]
	internal interface IPropertyMetadataFactory
	{
		PropertyMetadata CreateInstanceWithDefaultValue([In] object defaultValue, [In] object outer, out object inner);
		PropertyMetadata CreateInstanceWithDefaultValueAndCallback([In] object defaultValue, [In] PropertyChangedCallback propertyChangedCallback, [In] object outer, out object inner);
	}
}
