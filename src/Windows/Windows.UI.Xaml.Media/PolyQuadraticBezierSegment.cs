using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPolyQuadraticBezierSegmentStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Points")]
	public sealed class PolyQuadraticBezierSegment : PathSegment, IPolyQuadraticBezierSegment
	{
		public extern PointCollection Points
		{
			get;
			set;
		}
		public static extern DependencyProperty PointsProperty
		{
			get;
		}
		public extern PolyQuadraticBezierSegment();
	}
}
