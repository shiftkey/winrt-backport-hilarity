using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(EntranceThemeTransition)), Guid(124357641u, 43235, 16794, 160, 29, 116, 16, 160, 174, 142, 200), Version(100794368u), WebHostHidden]
	internal interface IEntranceThemeTransition
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
		bool IsStaggeringEnabled
		{
			get;
			set;
		}
	}
}
