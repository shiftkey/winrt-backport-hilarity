using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(ThicknessHelper)), Guid(3231259260u, 1804, 19878, 135, 132, 1, 202, 128, 14, 183, 58), Version(100794368u), WebHostHidden]
	internal interface IThicknessHelperStatics
	{
		Thickness FromLengths([In] double left, [In] double top, [In] double right, [In] double bottom);
		Thickness FromUniformLength([In] double uniformLength);
	}
}
