using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PopupThemeTransition)), Guid(3852559374u, 18701, 5381, 159, 107, 143, 175, 192, 68, 222, 197), Version(100794368u), WebHostHidden]
	internal interface IPopupThemeTransitionStatics
	{
		DependencyProperty FromHorizontalOffsetProperty
		{
			get;
		}
		DependencyProperty FromVerticalOffsetProperty
		{
			get;
		}
	}
}
