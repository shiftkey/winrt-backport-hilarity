using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PointAnimation)), Guid(821052178u, 30502, 20360, 184, 226, 47, 165, 69, 24, 150, 59), Version(100794368u), WebHostHidden]
	internal interface IPointAnimation
	{
		IReference<Point> By
		{
			get;
			set;
		}
		EasingFunctionBase EasingFunction
		{
			get;
			set;
		}
		bool EnableDependentAnimation
		{
			get;
			set;
		}
		IReference<Point> From
		{
			get;
			set;
		}
		IReference<Point> To
		{
			get;
			set;
		}
	}
}
