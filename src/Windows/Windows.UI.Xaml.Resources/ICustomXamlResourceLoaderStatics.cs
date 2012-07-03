using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Resources
{
	[ExclusiveTo(typeof(CustomXamlResourceLoader)), Guid(575665687u, 58588, 19495, 173, 50, 219, 147, 213, 208, 229, 218), Version(100794368u), WebHostHidden]
	internal interface ICustomXamlResourceLoaderStatics
	{
		CustomXamlResourceLoader Current
		{
			get;
			set;
		}
	}
}
