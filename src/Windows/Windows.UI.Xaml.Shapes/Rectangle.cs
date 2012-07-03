using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Shapes
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRectangleStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class Rectangle : Shape, IRectangle
	{
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
		public static extern DependencyProperty RadiusXProperty
		{
			get;
		}
		public static extern DependencyProperty RadiusYProperty
		{
			get;
		}
		public extern Rectangle();
	}
}
