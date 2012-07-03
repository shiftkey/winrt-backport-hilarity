using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(Brush)), Guid(966154402u, 5371, 19343, 131, 230, 110, 61, 171, 18, 6, 155), Version(100794368u), WebHostHidden]
	internal interface IBrushFactory
	{
		Brush CreateInstance([In] object outer, out object inner);
	}
}
