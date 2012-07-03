using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Rectangle)), Guid(2237383216u, 35345, 19992, 161, 54, 75, 194, 28, 120, 39, 176), Version(100794368u), WebHostHidden]
	internal interface IRectangle
	{
		double RadiusX
		{
			get;
			set;
		}
		double RadiusY
		{
			get;
			set;
		}
	}
}
