using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PopInThemeAnimation)), Guid(426326209u, 7175, 19496, 136, 71, 249, 240, 85, 179, 40, 85), Version(100794368u), WebHostHidden]
	internal interface IPopInThemeAnimation
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
