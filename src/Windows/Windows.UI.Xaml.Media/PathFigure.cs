using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPathFigureStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Segments")]
	public sealed class PathFigure : DependencyObject, IPathFigure
	{
		public extern bool IsClosed
		{
			get;
			set;
		}
		public extern bool IsFilled
		{
			get;
			set;
		}
		public extern PathSegmentCollection Segments
		{
			get;
			set;
		}
		public extern Point StartPoint
		{
			get;
			set;
		}
		public static extern DependencyProperty IsClosedProperty
		{
			get;
		}
		public static extern DependencyProperty IsFilledProperty
		{
			get;
		}
		public static extern DependencyProperty SegmentsProperty
		{
			get;
		}
		public static extern DependencyProperty StartPointProperty
		{
			get;
		}
		public extern PathFigure();
	}
}
