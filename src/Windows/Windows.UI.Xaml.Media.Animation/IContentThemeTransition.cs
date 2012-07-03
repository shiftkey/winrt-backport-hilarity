using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ContentThemeTransition)), Guid(4134520259u, 22805, 17277, 142, 59, 173, 248, 231, 240, 171, 87), Version(100794368u), WebHostHidden]
	internal interface IContentThemeTransition
	{
		double HorizontalOffset
		{
			get;
			set;
		}
		double VerticalOffset
		{
			get;
			set;
		}
	}
}
