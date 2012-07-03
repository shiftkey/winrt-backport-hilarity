using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(FadeOutThemeAnimation)), Guid(2301062057u, 65492, 17846, 155, 154, 206, 212, 137, 81, 231, 18), Version(100794368u), WebHostHidden]
	internal interface IFadeOutThemeAnimation
	{
		string TargetName
		{
			get;
			set;
		}
	}
}
