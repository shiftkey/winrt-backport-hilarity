using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(SwipeHintThemeAnimation)), Guid(3452987328u, 22542, 20032, 190, 152, 242, 2, 211, 216, 67, 101), Version(100794368u), WebHostHidden]
	internal interface ISwipeHintThemeAnimation
	{
		string TargetName
		{
			get;
			set;
		}
		double ToHorizontalOffset
		{
			get;
			set;
		}
		double ToVerticalOffset
		{
			get;
			set;
		}
	}
}
