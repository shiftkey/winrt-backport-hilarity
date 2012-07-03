using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(EntranceThemeTransition)), Guid(936117623u, 65432, 19181, 184, 110, 94, 194, 55, 2, 248, 119), Version(100794368u), WebHostHidden]
	internal interface IEntranceThemeTransitionStatics
	{
		DependencyProperty FromHorizontalOffsetProperty
		{
			get;
		}
		DependencyProperty FromVerticalOffsetProperty
		{
			get;
		}
		DependencyProperty IsStaggeringEnabledProperty
		{
			get;
		}
	}
}
