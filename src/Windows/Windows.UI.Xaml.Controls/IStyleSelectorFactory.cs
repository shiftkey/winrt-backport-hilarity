using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(StyleSelector)), Guid(2660510439u, 14177, 17535, 143, 151, 41, 227, 157, 94, 179, 16), Version(100794368u), WebHostHidden]
	internal interface IStyleSelectorFactory
	{
		StyleSelector CreateInstance([In] object outer, out object inner);
	}
}
