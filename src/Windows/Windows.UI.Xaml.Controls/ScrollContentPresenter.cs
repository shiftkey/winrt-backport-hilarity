using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ScrollContentPresenter : ContentPresenter, IScrollContentPresenter
	{
		public extern bool CanHorizontallyScroll
		{
			get;
			set;
		}
		public extern bool CanVerticallyScroll
		{
			get;
			set;
		}
		public extern double ExtentHeight
		{
			get;
		}
		public extern double ExtentWidth
		{
			get;
		}
		public extern double HorizontalOffset
		{
			get;
		}
		public extern object ScrollOwner
		{
			get;
			set;
		}
		public extern double VerticalOffset
		{
			get;
		}
		public extern double ViewportHeight
		{
			get;
		}
		public extern double ViewportWidth
		{
			get;
		}
		public extern ScrollContentPresenter();
		public extern void LineUp();
		public extern void LineDown();
		public extern void LineLeft();
		public extern void LineRight();
		public extern void PageUp();
		public extern void PageDown();
		public extern void PageLeft();
		public extern void PageRight();
		public extern void MouseWheelUp();
		public extern void MouseWheelDown();
		public extern void MouseWheelLeft();
		public extern void MouseWheelRight();
		public extern void SetHorizontalOffset([In] double offset);
		public extern void SetVerticalOffset([In] double offset);
		public extern Rect MakeVisible([In] UIElement visual, [In] Rect rectangle);
	}
}
