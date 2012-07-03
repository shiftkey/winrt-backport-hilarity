using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ILineSegmentStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class LineSegment : PathSegment, ILineSegment
	{
		public extern Point Point
		{
			get;
			set;
		}
		public static extern DependencyProperty PointProperty
		{
			get;
		}
		public extern LineSegment();
	}
}
