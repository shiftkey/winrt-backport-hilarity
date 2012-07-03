using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(GradientBrush)), Guid(3980884426u, 17853, 16689, 182, 37, 190, 134, 224, 124, 97, 18), Version(100794368u), WebHostHidden]
	internal interface IGradientBrushFactory
	{
		GradientBrush CreateInstance([In] object outer, out object inner);
	}
}
