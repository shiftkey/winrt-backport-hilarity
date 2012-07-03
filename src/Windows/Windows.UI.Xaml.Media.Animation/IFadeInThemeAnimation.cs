using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(FadeInThemeAnimation)), Guid(1833683189u, 43288, 17527, 128, 120, 85, 76, 104, 129, 42, 184), Version(100794368u), WebHostHidden]
	internal interface IFadeInThemeAnimation
	{
		string TargetName
		{
			get;
			set;
		}
	}
}
