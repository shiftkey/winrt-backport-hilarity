using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ScrollViewer)), Guid(869345693u, 36206, 17040, 191, 34, 144, 92, 204, 208, 77, 49), Version(100794368u), WebHostHidden]
	internal interface IScrollViewerStatics
	{
		DependencyProperty ComputedHorizontalScrollBarVisibilityProperty
		{
			get;
		}
		DependencyProperty ComputedVerticalScrollBarVisibilityProperty
		{
			get;
		}
		DependencyProperty ExtentHeightProperty
		{
			get;
		}
		DependencyProperty ExtentWidthProperty
		{
			get;
		}
		DependencyProperty HorizontalOffsetProperty
		{
			get;
		}
		DependencyProperty HorizontalScrollBarVisibilityProperty
		{
			get;
		}
		DependencyProperty HorizontalScrollModeProperty
		{
			get;
		}
		DependencyProperty HorizontalSnapPointsAlignmentProperty
		{
			get;
		}
		DependencyProperty HorizontalSnapPointsTypeProperty
		{
			get;
		}
		DependencyProperty IsHorizontalRailEnabledProperty
		{
			get;
		}
		DependencyProperty IsHorizontalScrollChainingEnabledProperty
		{
			get;
		}
		DependencyProperty IsScrollInertiaEnabledProperty
		{
			get;
		}
		DependencyProperty IsVerticalRailEnabledProperty
		{
			get;
		}
		DependencyProperty IsVerticalScrollChainingEnabledProperty
		{
			get;
		}
		DependencyProperty IsZoomChainingEnabledProperty
		{
			get;
		}
		DependencyProperty IsZoomInertiaEnabledProperty
		{
			get;
		}
		DependencyProperty MaxZoomFactorProperty
		{
			get;
		}
		DependencyProperty MinZoomFactorProperty
		{
			get;
		}
		DependencyProperty ScrollableHeightProperty
		{
			get;
		}
		DependencyProperty ScrollableWidthProperty
		{
			get;
		}
		DependencyProperty VerticalOffsetProperty
		{
			get;
		}
		DependencyProperty VerticalScrollBarVisibilityProperty
		{
			get;
		}
		DependencyProperty VerticalScrollModeProperty
		{
			get;
		}
		DependencyProperty VerticalSnapPointsAlignmentProperty
		{
			get;
		}
		DependencyProperty VerticalSnapPointsTypeProperty
		{
			get;
		}
		DependencyProperty ViewportHeightProperty
		{
			get;
		}
		DependencyProperty ViewportWidthProperty
		{
			get;
		}
		DependencyProperty ZoomFactorProperty
		{
			get;
		}
		DependencyProperty ZoomModeProperty
		{
			get;
		}
		DependencyProperty ZoomSnapPointsProperty
		{
			get;
		}
		DependencyProperty ZoomSnapPointsTypeProperty
		{
			get;
		}
		ScrollBarVisibility GetHorizontalScrollBarVisibility([In] DependencyObject element);
		void SetHorizontalScrollBarVisibility([In] DependencyObject element, [In] ScrollBarVisibility horizontalScrollBarVisibility);
		ScrollBarVisibility GetVerticalScrollBarVisibility([In] DependencyObject element);
		void SetVerticalScrollBarVisibility([In] DependencyObject element, [In] ScrollBarVisibility verticalScrollBarVisibility);
		bool GetIsHorizontalRailEnabled([In] DependencyObject element);
		void SetIsHorizontalRailEnabled([In] DependencyObject element, [In] bool isHorizontalRailEnabled);
		bool GetIsVerticalRailEnabled([In] DependencyObject element);
		void SetIsVerticalRailEnabled([In] DependencyObject element, [In] bool isVerticalRailEnabled);
		bool GetIsHorizontalScrollChainingEnabled([In] DependencyObject element);
		void SetIsHorizontalScrollChainingEnabled([In] DependencyObject element, [In] bool isHorizontalScrollChainingEnabled);
		bool GetIsVerticalScrollChainingEnabled([In] DependencyObject element);
		void SetIsVerticalScrollChainingEnabled([In] DependencyObject element, [In] bool isVerticalScrollChainingEnabled);
		bool GetIsZoomChainingEnabled([In] DependencyObject element);
		void SetIsZoomChainingEnabled([In] DependencyObject element, [In] bool isZoomChainingEnabled);
		bool GetIsScrollInertiaEnabled([In] DependencyObject element);
		void SetIsScrollInertiaEnabled([In] DependencyObject element, [In] bool isScrollInertiaEnabled);
		bool GetIsZoomInertiaEnabled([In] DependencyObject element);
		void SetIsZoomInertiaEnabled([In] DependencyObject element, [In] bool isZoomInertiaEnabled);
		ScrollMode GetHorizontalScrollMode([In] DependencyObject element);
		void SetHorizontalScrollMode([In] DependencyObject element, [In] ScrollMode horizontalScrollMode);
		ScrollMode GetVerticalScrollMode([In] DependencyObject element);
		void SetVerticalScrollMode([In] DependencyObject element, [In] ScrollMode verticalScrollMode);
		ZoomMode GetZoomMode([In] DependencyObject element);
		void SetZoomMode([In] DependencyObject element, [In] ZoomMode zoomMode);
	}
}
