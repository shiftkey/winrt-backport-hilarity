using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ContentThemeTransition)), Guid(244245381u, 39490, 17497, 175, 169, 51, 125, 196, 30, 21, 135), Version(100794368u), WebHostHidden]
	internal interface IContentThemeTransitionStatics
	{
		DependencyProperty HorizontalOffsetProperty
		{
			get;
		}
		DependencyProperty VerticalOffsetProperty
		{
			get;
		}
	}
}
