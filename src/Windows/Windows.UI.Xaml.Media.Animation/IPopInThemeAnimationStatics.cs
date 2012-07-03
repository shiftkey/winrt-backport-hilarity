using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PopInThemeAnimation)), Guid(4020935123u, 8586, 18177, 151, 127, 241, 191, 174, 139, 166, 73), Version(100794368u), WebHostHidden]
	internal interface IPopInThemeAnimationStatics
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
