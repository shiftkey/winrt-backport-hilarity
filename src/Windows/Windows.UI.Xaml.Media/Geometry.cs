using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Composable(typeof(IGeometryFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGeometryStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Geometry : DependencyObject, IGeometry
	{
		public extern Rect Bounds
		{
			get;
		}
		public extern Transform Transform
		{
			get;
			set;
		}
		public static extern Geometry Empty
		{
			get;
		}
		public static extern double StandardFlatteningTolerance
		{
			get;
		}
		public static extern DependencyProperty TransformProperty
		{
			get;
		}
	}
}
