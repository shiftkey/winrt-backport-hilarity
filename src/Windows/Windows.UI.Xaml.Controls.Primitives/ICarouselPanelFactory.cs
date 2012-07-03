using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(CarouselPanel)), Guid(3239089156u, 39649, 17422, 160, 221, 187, 182, 226, 41, 60, 190), Version(100794368u), WebHostHidden]
	internal interface ICarouselPanelFactory
	{
		CarouselPanel CreateInstance([In] object outer, out object inner);
	}
}
