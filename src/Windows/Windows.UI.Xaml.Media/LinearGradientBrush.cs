using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(typeof(ILinearGradientBrushFactory), 100794368u), Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ILinearGradientBrushStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class LinearGradientBrush : GradientBrush, ILinearGradientBrush
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
		public extern LinearGradientBrush();
		public extern LinearGradientBrush([In] GradientStopCollection gradientStopCollection, [In] double angle);
	}
}
