using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ILineGeometryStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class LineGeometry : Geometry, ILineGeometry
	{
		public extern Point EndPoint
		{
			get;
			set;
		}
		public extern Point StartPoint
		{
			get;
			set;
		}
		public static extern DependencyProperty EndPointProperty
		{
			get;
		}
		public static extern DependencyProperty StartPointProperty
		{
			get;
		}
		public extern LineGeometry();
	}
}
