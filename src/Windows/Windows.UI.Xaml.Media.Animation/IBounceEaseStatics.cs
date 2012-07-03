using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(BounceEase)), Guid(3228573090u, 20339, 16841, 178, 203, 46, 163, 16, 81, 7, 255), Version(100794368u), WebHostHidden]
	internal interface IBounceEaseStatics
	{
		DependencyProperty BouncesProperty
		{
			get;
		}
		DependencyProperty BouncinessProperty
		{
			get;
		}
	}
}
