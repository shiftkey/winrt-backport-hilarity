using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IQuadraticBezierSegmentStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class QuadraticBezierSegment : PathSegment, IQuadraticBezierSegment
	{
		public extern Point Point1
		{
			get;
			set;
		}
		public extern Point Point2
		{
			get;
			set;
		}
		public static extern DependencyProperty Point1Property
		{
			get;
		}
		public static extern DependencyProperty Point2Property
		{
			get;
		}
		public extern QuadraticBezierSegment();
	}
}
