using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(SplineDoubleKeyFrame)), Guid(14101816u, 27435, 18499, 131, 142, 200, 177, 21, 238, 200, 1), Version(100794368u), WebHostHidden]
	internal interface ISplineDoubleKeyFrame
	{
		KeySpline KeySpline
		{
			get;
			set;
		}
	}
}
