using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(ArcSegment)), Guid(127143007u, 25595, 17513, 145, 190, 241, 9, 124, 22, 128, 82), Version(100794368u), WebHostHidden]
	internal interface IArcSegment
	{
		bool IsLargeArc
		{
			get;
			set;
		}
		Point Point
		{
			get;
			set;
		}
		double RotationAngle
		{
			get;
			set;
		}
		Size Size
		{
			get;
			set;
		}
		SweepDirection SweepDirection
		{
			get;
			set;
		}
	}
}
