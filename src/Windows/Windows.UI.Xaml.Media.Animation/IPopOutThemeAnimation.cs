using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(PopOutThemeAnimation)), Guid(1200008009u, 3656, 20097, 162, 229, 204, 90, 161, 158, 72, 211), Version(100794368u), WebHostHidden]
	internal interface IPopOutThemeAnimation
	{
		string TargetName
		{
			get;
			set;
		}
	}
}
