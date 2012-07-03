using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Shapes
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPolylineStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class Polyline : Shape, IPolyline
	{
		public extern FillRule FillRule
		{
			get;
			set;
		}
		public extern PointCollection Points
		{
			get;
			set;
		}
		public static extern DependencyProperty FillRuleProperty
		{
			get;
		}
		public static extern DependencyProperty PointsProperty
		{
			get;
		}
		public extern Polyline();
	}
}
