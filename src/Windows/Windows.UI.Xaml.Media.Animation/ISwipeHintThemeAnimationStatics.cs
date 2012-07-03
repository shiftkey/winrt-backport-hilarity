using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(SwipeHintThemeAnimation)), Guid(601234007u, 37141, 19811, 176, 74, 184, 159, 28, 116, 77, 192), Version(100794368u), WebHostHidden]
	internal interface ISwipeHintThemeAnimationStatics
	{
		DependencyProperty TargetNameProperty
		{
			get;
		}
		DependencyProperty ToHorizontalOffsetProperty
		{
			get;
		}
		DependencyProperty ToVerticalOffsetProperty
		{
			get;
		}
	}
}
