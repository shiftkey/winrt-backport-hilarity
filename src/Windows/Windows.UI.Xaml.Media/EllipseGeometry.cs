using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IEllipseGeometryStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class EllipseGeometry : Geometry, IEllipseGeometry
	{
		public extern Point Center
		{
			get;
			set;
		}
		public extern double RadiusX
		{
			get;
			set;
		}
		public extern double RadiusY
		{
			get;
			set;
		}
		public static extern DependencyProperty CenterProperty
		{
			get;
		}
		public static extern DependencyProperty RadiusXProperty
		{
			get;
		}
		public static extern DependencyProperty RadiusYProperty
		{
			get;
		}
		public extern EllipseGeometry();
	}
}
