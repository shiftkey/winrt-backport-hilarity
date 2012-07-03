using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(TileBrush)), Guid(2853543804u, 60778, 20403, 176, 20, 181, 199, 227, 121, 164, 222), Version(100794368u), WebHostHidden]
	internal interface ITileBrushFactory
	{
		TileBrush CreateInstance([In] object outer, out object inner);
	}
}
