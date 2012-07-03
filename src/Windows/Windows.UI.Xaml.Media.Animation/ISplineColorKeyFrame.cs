using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(SplineColorKeyFrame)), Guid(441080129u, 8160, 18234, 142, 254, 67, 22, 216, 200, 98, 41), Version(100794368u), WebHostHidden]
	internal interface ISplineColorKeyFrame
	{
		KeySpline KeySpline
		{
			get;
			set;
		}
	}
}
