using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(PolyBezierSegment)), Guid(914379377u, 14532, 19407, 150, 205, 2, 138, 109, 56, 175, 37), Version(100794368u), WebHostHidden]
	internal interface IPolyBezierSegment
	{
		PointCollection Points
		{
			get;
			set;
		}
	}
}
