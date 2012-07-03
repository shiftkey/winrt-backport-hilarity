using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(TileBrush)), Guid(882360923u, 46434, 20072, 132, 53, 35, 153, 246, 235, 148, 213), Version(100794368u), WebHostHidden]
	internal interface ITileBrushStatics
	{
		DependencyProperty AlignmentXProperty
		{
			get;
		}
		DependencyProperty AlignmentYProperty
		{
			get;
		}
		DependencyProperty StretchProperty
		{
			get;
		}
	}
}
