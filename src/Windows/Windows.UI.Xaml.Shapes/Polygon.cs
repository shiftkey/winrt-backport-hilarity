using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Shapes
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPolygonStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class Polygon : Shape, IPolygon
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
		public extern Polygon();
	}
}
