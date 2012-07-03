using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Slider)), Guid(61242167u, 51135, 17276, 132, 143, 140, 181, 183, 83, 234, 180), Version(100794368u), WebHostHidden]
	internal interface ISliderFactory
	{
		Slider CreateInstance([In] object outer, out object inner);
	}
}
