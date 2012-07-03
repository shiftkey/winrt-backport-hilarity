using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IScrollBarStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ScrollBar : RangeBase, IScrollBar
	{
		public extern event ScrollEventHandler Scroll
		{
			add;
			remove;
		}
		public extern ScrollingIndicatorMode IndicatorMode
		{
			get;
			set;
		}
		public extern Orientation Orientation
		{
			get;
			set;
		}
		public extern double ViewportSize
		{
			get;
			set;
		}
		public static extern DependencyProperty IndicatorModeProperty
		{
			get;
		}
		public static extern DependencyProperty OrientationProperty
		{
			get;
		}
		public static extern DependencyProperty ViewportSizeProperty
		{
			get;
		}
		public extern ScrollBar();
	}
}
