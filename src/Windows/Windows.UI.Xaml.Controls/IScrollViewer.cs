using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ScrollViewer)), Guid(1693040128u, 19905, 18749, 171, 231, 203, 211, 197, 119, 73, 13), Version(100794368u), WebHostHidden]
	internal interface IScrollViewer
	{
		event EventHandler<ScrollViewerViewChangedEventArgs> ViewChanged;
		Visibility ComputedHorizontalScrollBarVisibility
		{
			get;
		}
		Visibility ComputedVerticalScrollBarVisibility
		{
			get;
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
		ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get;
			set;
		}
		ScrollMode HorizontalScrollMode
		{
			get;
			set;
		}
		SnapPointsAlignment HorizontalSnapPointsAlignment
		{
			get;
			set;
		}
		SnapPointsType HorizontalSnapPointsType
		{
			get;
			set;
		}
		bool IsHorizontalRailEnabled
		{
			get;
			set;
		}
		bool IsHorizontalScrollChainingEnabled
		{
			get;
			set;
		}
		bool IsScrollInertiaEnabled
		{
			get;
			set;
		}
		bool IsVerticalRailEnabled
		{
			get;
			set;
		}
		bool IsVerticalScrollChainingEnabled
		{
			get;
			set;
		}
		bool IsZoomChainingEnabled
		{
			get;
			set;
		}
		bool IsZoomInertiaEnabled
		{
			get;
			set;
		}
		float MaxZoomFactor
		{
			get;
			set;
		}
		float MinZoomFactor
		{
			get;
			set;
		}
		double ScrollableHeight
		{
			get;
		}
		double ScrollableWidth
		{
			get;
		}
		double VerticalOffset
		{
			get;
		}
		ScrollBarVisibility VerticalScrollBarVisibility
		{
			get;
			set;
		}
		ScrollMode VerticalScrollMode
		{
			get;
			set;
		}
		SnapPointsAlignment VerticalSnapPointsAlignment
		{
			get;
			set;
		}
		SnapPointsType VerticalSnapPointsType
		{
			get;
			set;
		}
		double ViewportHeight
		{
			get;
		}
		double ViewportWidth
		{
			get;
		}
		float ZoomFactor
		{
			get;
		}
		ZoomMode ZoomMode
		{
			get;
			set;
		}
		IVector<float> ZoomSnapPoints
		{
			get;
		}
		SnapPointsType ZoomSnapPointsType
		{
			get;
			set;
		}
		void ScrollToHorizontalOffset([In] double offset);
		void ScrollToVerticalOffset([In] double offset);
		void ZoomToFactor([In] float factor);
		void InvalidateScrollInfo();
	}
}
