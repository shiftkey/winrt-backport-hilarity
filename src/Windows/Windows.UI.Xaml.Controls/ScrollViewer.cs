using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IScrollViewerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ScrollViewer : ContentControl, IScrollViewer
	{
		public extern event EventHandler<ScrollViewerViewChangedEventArgs> ViewChanged
		{
			add;
			remove;
		}
		public extern Visibility ComputedHorizontalScrollBarVisibility
		{
			get;
		}
		public extern Visibility ComputedVerticalScrollBarVisibility
		{
			get;
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
		public extern ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get;
			set;
		}
		public extern ScrollMode HorizontalScrollMode
		{
			get;
			set;
		}
		public extern SnapPointsAlignment HorizontalSnapPointsAlignment
		{
			get;
			set;
		}
		public extern SnapPointsType HorizontalSnapPointsType
		{
			get;
			set;
		}
		public extern bool IsHorizontalRailEnabled
		{
			get;
			set;
		}
		public extern bool IsHorizontalScrollChainingEnabled
		{
			get;
			set;
		}
		public extern bool IsScrollInertiaEnabled
		{
			get;
			set;
		}
		public extern bool IsVerticalRailEnabled
		{
			get;
			set;
		}
		public extern bool IsVerticalScrollChainingEnabled
		{
			get;
			set;
		}
		public extern bool IsZoomChainingEnabled
		{
			get;
			set;
		}
		public extern bool IsZoomInertiaEnabled
		{
			get;
			set;
		}
		public extern float MaxZoomFactor
		{
			get;
			set;
		}
		public extern float MinZoomFactor
		{
			get;
			set;
		}
		public extern double ScrollableHeight
		{
			get;
		}
		public extern double ScrollableWidth
		{
			get;
		}
		public extern double VerticalOffset
		{
			get;
		}
		public extern ScrollBarVisibility VerticalScrollBarVisibility
		{
			get;
			set;
		}
		public extern ScrollMode VerticalScrollMode
		{
			get;
			set;
		}
		public extern SnapPointsAlignment VerticalSnapPointsAlignment
		{
			get;
			set;
		}
		public extern SnapPointsType VerticalSnapPointsType
		{
			get;
			set;
		}
		public extern double ViewportHeight
		{
			get;
		}
		public extern double ViewportWidth
		{
			get;
		}
		public extern float ZoomFactor
		{
			get;
		}
		public extern ZoomMode ZoomMode
		{
			get;
			set;
		}
		public extern IVector<float> ZoomSnapPoints
		{
			get;
		}
		public extern SnapPointsType ZoomSnapPointsType
		{
			get;
			set;
		}
		public static extern DependencyProperty ComputedHorizontalScrollBarVisibilityProperty
		{
			get;
		}
		public static extern DependencyProperty ComputedVerticalScrollBarVisibilityProperty
		{
			get;
		}
		public static extern DependencyProperty ExtentHeightProperty
		{
			get;
		}
		public static extern DependencyProperty ExtentWidthProperty
		{
			get;
		}
		public static extern DependencyProperty HorizontalOffsetProperty
		{
			get;
		}
		public static extern DependencyProperty HorizontalScrollBarVisibilityProperty
		{
			get;
		}
		public static extern DependencyProperty HorizontalScrollModeProperty
		{
			get;
		}
		public static extern DependencyProperty HorizontalSnapPointsAlignmentProperty
		{
			get;
		}
		public static extern DependencyProperty HorizontalSnapPointsTypeProperty
		{
			get;
		}
		public static extern DependencyProperty IsHorizontalRailEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsHorizontalScrollChainingEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsScrollInertiaEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsVerticalRailEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsVerticalScrollChainingEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsZoomChainingEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsZoomInertiaEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty MaxZoomFactorProperty
		{
			get;
		}
		public static extern DependencyProperty MinZoomFactorProperty
		{
			get;
		}
		public static extern DependencyProperty ScrollableHeightProperty
		{
			get;
		}
		public static extern DependencyProperty ScrollableWidthProperty
		{
			get;
		}
		public static extern DependencyProperty VerticalOffsetProperty
		{
			get;
		}
		public static extern DependencyProperty VerticalScrollBarVisibilityProperty
		{
			get;
		}
		public static extern DependencyProperty VerticalScrollModeProperty
		{
			get;
		}
		public static extern DependencyProperty VerticalSnapPointsAlignmentProperty
		{
			get;
		}
		public static extern DependencyProperty VerticalSnapPointsTypeProperty
		{
			get;
		}
		public static extern DependencyProperty ViewportHeightProperty
		{
			get;
		}
		public static extern DependencyProperty ViewportWidthProperty
		{
			get;
		}
		public static extern DependencyProperty ZoomFactorProperty
		{
			get;
		}
		public static extern DependencyProperty ZoomModeProperty
		{
			get;
		}
		public static extern DependencyProperty ZoomSnapPointsProperty
		{
			get;
		}
		public static extern DependencyProperty ZoomSnapPointsTypeProperty
		{
			get;
		}
		public extern ScrollViewer();
		public extern void ScrollToHorizontalOffset([In] double offset);
		public extern void ScrollToVerticalOffset([In] double offset);
		public extern void ZoomToFactor([In] float factor);
		public extern void InvalidateScrollInfo();
		public static extern ScrollBarVisibility GetHorizontalScrollBarVisibility([In] DependencyObject element);
		public static extern void SetHorizontalScrollBarVisibility([In] DependencyObject element, [In] ScrollBarVisibility horizontalScrollBarVisibility);
		public static extern ScrollBarVisibility GetVerticalScrollBarVisibility([In] DependencyObject element);
		public static extern void SetVerticalScrollBarVisibility([In] DependencyObject element, [In] ScrollBarVisibility verticalScrollBarVisibility);
		public static extern bool GetIsHorizontalRailEnabled([In] DependencyObject element);
		public static extern void SetIsHorizontalRailEnabled([In] DependencyObject element, [In] bool isHorizontalRailEnabled);
		public static extern bool GetIsVerticalRailEnabled([In] DependencyObject element);
		public static extern void SetIsVerticalRailEnabled([In] DependencyObject element, [In] bool isVerticalRailEnabled);
		public static extern bool GetIsHorizontalScrollChainingEnabled([In] DependencyObject element);
		public static extern void SetIsHorizontalScrollChainingEnabled([In] DependencyObject element, [In] bool isHorizontalScrollChainingEnabled);
		public static extern bool GetIsVerticalScrollChainingEnabled([In] DependencyObject element);
		public static extern void SetIsVerticalScrollChainingEnabled([In] DependencyObject element, [In] bool isVerticalScrollChainingEnabled);
		public static extern bool GetIsZoomChainingEnabled([In] DependencyObject element);
		public static extern void SetIsZoomChainingEnabled([In] DependencyObject element, [In] bool isZoomChainingEnabled);
		public static extern bool GetIsScrollInertiaEnabled([In] DependencyObject element);
		public static extern void SetIsScrollInertiaEnabled([In] DependencyObject element, [In] bool isScrollInertiaEnabled);
		public static extern bool GetIsZoomInertiaEnabled([In] DependencyObject element);
		public static extern void SetIsZoomInertiaEnabled([In] DependencyObject element, [In] bool isZoomInertiaEnabled);
		public static extern ScrollMode GetHorizontalScrollMode([In] DependencyObject element);
		public static extern void SetHorizontalScrollMode([In] DependencyObject element, [In] ScrollMode horizontalScrollMode);
		public static extern ScrollMode GetVerticalScrollMode([In] DependencyObject element);
		public static extern void SetVerticalScrollMode([In] DependencyObject element, [In] ScrollMode verticalScrollMode);
		public static extern ZoomMode GetZoomMode([In] DependencyObject element);
		public static extern void SetZoomMode([In] DependencyObject element, [In] ZoomMode zoomMode);
	}
}
