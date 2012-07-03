using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(DataTemplateSelector)), Guid(1360767696u, 8458, 17789, 149, 33, 67, 61, 43, 17, 183, 210), Version(100794368u), WebHostHidden]
	internal interface IDataTemplateSelectorFactory
	{
		DataTemplateSelector CreateInstance([In] object outer, out object inner);
	}
}
