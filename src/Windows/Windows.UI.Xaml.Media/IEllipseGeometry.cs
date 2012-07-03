using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(EllipseGeometry)), Guid(3572898746u, 20130, 16598, 170, 108, 141, 56, 170, 135, 101, 31), Version(100794368u), WebHostHidden]
	internal interface IEllipseGeometry
	{
		Point Center
		{
			get;
			set;
		}
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
