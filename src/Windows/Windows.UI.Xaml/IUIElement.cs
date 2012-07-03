using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(UIElement)), Guid(1735199721u, 46684, 16838, 186, 64, 88, 207, 135, 242, 1, 193), Version(100794368u), WebHostHidden]
	internal interface IUIElement
	{
		event DoubleTappedEventHandler DoubleTapped;
		event DragEventHandler DragEnter;
		event DragEventHandler DragLeave;
		event DragEventHandler DragOver;
		event DragEventHandler Drop;
		event RoutedEventHandler GotFocus;
		event HoldingEventHandler Holding;
		event KeyEventHandler KeyDown;
		event KeyEventHandler KeyUp;
		event RoutedEventHandler LostFocus;
		event ManipulationCompletedEventHandler ManipulationCompleted;
		event ManipulationDeltaEventHandler ManipulationDelta;
		event ManipulationInertiaStartingEventHandler ManipulationInertiaStarting;
		event ManipulationStartedEventHandler ManipulationStarted;
		event ManipulationStartingEventHandler ManipulationStarting;
		event PointerEventHandler PointerCanceled;
		event PointerEventHandler PointerCaptureLost;
		event PointerEventHandler PointerEntered;
		event PointerEventHandler PointerExited;
		event PointerEventHandler PointerMoved;
		event PointerEventHandler PointerPressed;
		event PointerEventHandler PointerReleased;
		event PointerEventHandler PointerWheelChanged;
		event RightTappedEventHandler RightTapped;
		event TappedEventHandler Tapped;
		bool AllowDrop
		{
			get;
			set;
		}
		CacheMode CacheMode
		{
			get;
			set;
		}
		RectangleGeometry Clip
		{
			get;
			set;
		}
		Size DesiredSize
		{
			get;
		}
		bool IsDoubleTapEnabled
		{
			get;
			set;
		}
		bool IsHitTestVisible
		{
			get;
			set;
		}
		bool IsHoldingEnabled
		{
			get;
			set;
		}
		bool IsRightTapEnabled
		{
			get;
			set;
		}
		bool IsTapEnabled
		{
			get;
			set;
		}
		ManipulationModes ManipulationMode
		{
			get;
			set;
		}
		double Opacity
		{
			get;
			set;
		}
		IVectorView<Pointer> PointerCaptures
		{
			get;
		}
		Projection Projection
		{
			get;
			set;
		}
		Size RenderSize
		{
			get;
		}
		Transform RenderTransform
		{
			get;
			set;
		}
		Point RenderTransformOrigin
		{
			get;
			set;
		}
		TransitionCollection Transitions
		{
			get;
			set;
		}
		bool UseLayoutRounding
		{
			get;
			set;
		}
		Visibility Visibility
		{
			get;
			set;
		}
		void Measure([In] Size availableSize);
		void Arrange([In] Rect finalRect);
		bool CapturePointer([In] Pointer value);
		void ReleasePointerCapture([In] Pointer value);
		void ReleasePointerCaptures();
		void AddHandler([In] RoutedEvent routedEvent, [In] object handler, [In] bool handledEventsToo);
		void RemoveHandler([In] RoutedEvent routedEvent, [In] object handler);
		GeneralTransform TransformToVisual([In] UIElement visual);
		void InvalidateMeasure();
		void InvalidateArrange();
		void UpdateLayout();
	}
}
