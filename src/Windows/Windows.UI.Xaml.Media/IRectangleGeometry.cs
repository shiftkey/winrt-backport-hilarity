using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(RectangleGeometry)), Guid(2723815256u, 50549, 16790, 145, 207, 159, 223, 177, 4, 69, 195), Version(100794368u), WebHostHidden]
	internal interface IRectangleGeometry
	{
		Rect Rect
		{
			get;
			set;
		}
	}
}
