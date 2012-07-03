using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(RepositionThemeAnimation)), Guid(3973719272u, 35141, 18761, 161, 191, 98, 16, 153, 101, 167, 233), Version(100794368u), WebHostHidden]
	internal interface IRepositionThemeAnimation
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
