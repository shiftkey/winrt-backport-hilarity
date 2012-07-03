using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(OrientedVirtualizingPanel)), Guid(4034377079u, 14781, 18158, 189, 215, 8, 38, 190, 237, 113, 184), Version(100794368u), WebHostHidden]
	internal interface IOrientedVirtualizingPanel
	{
		bool CanHorizontallyScroll
		{
			get;
			set;
		}
		bool CanVerticallyScroll
		{
			get;
			set;
		}
		double ExtentHeight
		{
			get;
		}
		double ExtentWidth
		{
			get;
		}
		double HorizontalOffset
		{
			get;
		}
		object ScrollOwner
		{
			get;
			set;
		}
		double VerticalOffset
		{
			get;
		}
		double ViewportHeight
		{
			get;
		}
		double ViewportWidth
		{
			get;
		}
		void LineUp();
		void LineDown();
		void LineLeft();
		void LineRight();
		void PageUp();
		void PageDown();
		void PageLeft();
		void PageRight();
		void MouseWheelUp();
		void MouseWheelDown();
		void MouseWheelLeft();
		void MouseWheelRight();
		void SetHorizontalOffset([In] double offset);
		void SetVerticalOffset([In] double offset);
		Rect MakeVisible([In] UIElement visual, [In] Rect rectangle);
	}
}
