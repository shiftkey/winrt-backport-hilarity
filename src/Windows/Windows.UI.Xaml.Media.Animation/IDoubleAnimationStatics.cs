using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(DoubleAnimation)), Guid(3799683933u, 61713, 17335, 184, 36, 131, 43, 88, 215, 120, 107), Version(100794368u), WebHostHidden]
	internal interface IDoubleAnimationStatics
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
