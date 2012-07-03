using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(PathFigure)), Guid(1570069644u, 24489, 19930, 163, 204, 16, 252, 220, 170, 32, 215), Version(100794368u), WebHostHidden]
	internal interface IPathFigure
	{
		bool IsClosed
		{
			get;
			set;
		}
		bool IsFilled
		{
			get;
			set;
		}
		PathSegmentCollection Segments
		{
			get;
			set;
		}
		Point StartPoint
		{
			get;
			set;
		}
	}
}
