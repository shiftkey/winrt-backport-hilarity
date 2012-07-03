using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(PropertyMetadata)), Guid(2169434893u, 36120, 17546, 134, 68, 242, 203, 81, 231, 3, 128), Version(100794368u), WebHostHidden]
	internal interface IPropertyMetadata
	{
		CreateDefaultValueCallback CreateDefaultValueCallback
		{
			get;
		}
		object DefaultValue
		{
			get;
		}
	}
}
