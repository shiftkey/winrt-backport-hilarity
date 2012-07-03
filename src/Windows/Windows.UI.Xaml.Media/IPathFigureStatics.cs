using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(PathFigure)), Guid(3053818329u, 9109, 17175, 149, 82, 58, 88, 82, 111, 140, 123), Version(100794368u), WebHostHidden]
	internal interface IPathFigureStatics
	{
		DependencyProperty IsClosedProperty
		{
			get;
		}
		DependencyProperty IsFilledProperty
		{
			get;
		}
		DependencyProperty SegmentsProperty
		{
			get;
		}
		DependencyProperty StartPointProperty
		{
			get;
		}
	}
}
