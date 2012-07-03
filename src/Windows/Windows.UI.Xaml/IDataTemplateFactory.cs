using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DataTemplate)), Guid(1374526846u, 11091, 18267, 156, 136, 12, 24, 50, 200, 53, 26), Version(100794368u), WebHostHidden]
	internal interface IDataTemplateFactory
	{
		DataTemplate CreateInstance([In] object outer, out object inner);
	}
}
