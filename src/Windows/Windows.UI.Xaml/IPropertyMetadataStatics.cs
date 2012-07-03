using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(PropertyMetadata)), Guid(989923194u, 28166, 17897, 139, 92, 175, 36, 52, 88, 192, 98), Version(100794368u), WebHostHidden]
	internal interface IPropertyMetadataStatics
	{
		[DefaultOverload, Overload("CreateWithDefaultValue")]
		PropertyMetadata Create([In] object defaultValue);
		[DefaultOverload, Overload("CreateWithDefaultValueAndCallback")]
		PropertyMetadata Create([In] object defaultValue, [In] PropertyChangedCallback propertyChangedCallback);
		[Overload("CreateWithFactory")]
		PropertyMetadata Create([In] CreateDefaultValueCallback createDefaultValueCallback);
		[Overload("CreateWithFactoryAndCallback")]
		PropertyMetadata Create([In] CreateDefaultValueCallback createDefaultValueCallback, [In] PropertyChangedCallback propertyChangedCallback);
	}
}
