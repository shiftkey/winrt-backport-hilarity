using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(SwipeBackThemeAnimation)), Guid(2743747092u, 3018, 19757, 149, 247, 206, 186, 87, 251, 175, 96), Version(100794368u), WebHostHidden]
	internal interface ISwipeBackThemeAnimation
	{
		double FromHorizontalOffset
		{
			get;
			set;
		}
		double FromVerticalOffset
		{
			get;
			set;
		}
		string TargetName
		{
			get;
			set;
		}
	}
}
