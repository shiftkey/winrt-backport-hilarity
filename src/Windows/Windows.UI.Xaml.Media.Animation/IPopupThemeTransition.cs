using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PopupThemeTransition)), Guid(1199846738u, 17027, 21598, 199, 145, 38, 141, 202, 34, 206, 75), Version(100794368u), WebHostHidden]
	internal interface IPopupThemeTransition
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
	}
}
