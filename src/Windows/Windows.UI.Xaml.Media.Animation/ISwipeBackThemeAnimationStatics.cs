using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(SwipeBackThemeAnimation)), Guid(1765749183u, 19878, 18058, 140, 224, 153, 108, 154, 173, 66, 224), Version(100794368u), WebHostHidden]
	internal interface ISwipeBackThemeAnimationStatics
	{
		DependencyProperty FromHorizontalOffsetProperty
		{
			get;
		}
		DependencyProperty FromVerticalOffsetProperty
		{
			get;
		}
		DependencyProperty TargetNameProperty
		{
			get;
		}
	}
}
