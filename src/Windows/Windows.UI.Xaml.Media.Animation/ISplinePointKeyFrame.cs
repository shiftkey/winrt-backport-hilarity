using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(SplinePointKeyFrame)), Guid(253358854u, 28726, 18767, 188, 60, 120, 13, 240, 204, 82, 74), Version(100794368u), WebHostHidden]
	internal interface ISplinePointKeyFrame
	{
		KeySpline KeySpline
		{
			get;
			set;
		}
	}
}
