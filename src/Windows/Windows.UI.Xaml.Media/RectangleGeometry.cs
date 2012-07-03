using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRectangleGeometryStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class RectangleGeometry : Geometry, IRectangleGeometry
	{
		public extern Rect Rect
		{
			get;
			set;
		}
		public static extern DependencyProperty RectProperty
		{
			get;
		}
		public extern RectangleGeometry();
	}
}
