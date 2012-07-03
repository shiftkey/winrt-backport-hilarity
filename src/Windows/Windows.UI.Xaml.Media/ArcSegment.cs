using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IArcSegmentStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ArcSegment : PathSegment, IArcSegment
	{
		public extern bool IsLargeArc
		{
			get;
			set;
		}
		public extern Point Point
		{
			get;
			set;
		}
		public extern double RotationAngle
		{
			get;
			set;
		}
		public extern Size Size
		{
			get;
			set;
		}
		public extern SweepDirection SweepDirection
		{
			get;
			set;
		}
		public static extern DependencyProperty IsLargeArcProperty
		{
			get;
		}
		public static extern DependencyProperty PointProperty
		{
			get;
		}
		public static extern DependencyProperty RotationAngleProperty
		{
			get;
		}
		public static extern DependencyProperty SizeProperty
		{
			get;
		}
		public static extern DependencyProperty SweepDirectionProperty
		{
			get;
		}
		public extern ArcSegment();
	}
}
