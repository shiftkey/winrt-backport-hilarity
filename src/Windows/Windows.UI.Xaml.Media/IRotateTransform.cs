using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(RotateTransform)), Guid(1754180025u, 7758, 17814, 134, 227, 66, 139, 39, 51, 79, 175), Version(100794368u), WebHostHidden]
	internal interface IRotateTransform
	{
		double Angle
		{
			get;
			set;
		}
		double CenterX
		{
			get;
			set;
		}
		double CenterY
		{
			get;
			set;
		}
	}
}
