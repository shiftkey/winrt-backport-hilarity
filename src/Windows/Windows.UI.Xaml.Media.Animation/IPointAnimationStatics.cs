using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PointAnimation)), Guid(798602070u, 59191, 16523, 160, 253, 50, 120, 38, 211, 34, 85), Version(100794368u), WebHostHidden]
	internal interface IPointAnimationStatics
	{
		DependencyProperty ByProperty
		{
			get;
		}
		DependencyProperty EasingFunctionProperty
		{
			get;
		}
		DependencyProperty EnableDependentAnimationProperty
		{
			get;
		}
		DependencyProperty FromProperty
		{
			get;
		}
		DependencyProperty ToProperty
		{
			get;
		}
	}
}
