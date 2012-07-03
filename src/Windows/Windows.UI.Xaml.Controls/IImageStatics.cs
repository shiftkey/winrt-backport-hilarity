using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Image)), Guid(2307929970u, 49974, 17361, 157, 81, 195, 187, 213, 213, 214, 145), Version(100794368u), WebHostHidden]
	internal interface IImageStatics
	{
		DependencyProperty NineGridProperty
		{
			get;
		}
		DependencyProperty PlayToSourceProperty
		{
			get;
		}
		DependencyProperty SourceProperty
		{
			get;
		}
		DependencyProperty StretchProperty
		{
			get;
		}
	}
}
