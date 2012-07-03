using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IUIElementFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IUIElementStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class UIElement : DependencyObject, IUIElement, IUIElementOverrides
	{
		public extern event DoubleTappedEventHandler DoubleTapped
		{
			add;
			remove;
		}
		public extern event DragEventHandler DragEnter
		{
			add;
			remove;
		}
		public extern event DragEventHandler DragLeave
		{
			add;
			remove;
		}
		public extern event DragEventHandler DragOver
		{
			add;
			remove;
		}
		public extern event DragEventHandler Drop
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler GotFocus
		{
			add;
			remove;
		}
		public extern event HoldingEventHandler Holding
		{
			add;
			remove;
		}
		public extern event KeyEventHandler KeyDown
		{
			add;
			remove;
		}
		public extern event KeyEventHandler KeyUp
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler LostFocus
		{
			add;
			remove;
		}
		public extern event ManipulationCompletedEventHandler ManipulationCompleted
		{
			add;
			remove;
		}
		public extern event ManipulationDeltaEventHandler ManipulationDelta
		{
			add;
			remove;
		}
		public extern event ManipulationInertiaStartingEventHandler ManipulationInertiaStarting
		{
			add;
			remove;
		}
		public extern event ManipulationStartedEventHandler ManipulationStarted
		{
			add;
			remove;
		}
		public extern event ManipulationStartingEventHandler ManipulationStarting
		{
			add;
			remove;
		}
		public extern event PointerEventHandler PointerCanceled
		{
			add;
			remove;
		}
		public extern event PointerEventHandler PointerCaptureLost
		{
			add;
			remove;
		}
		public extern event PointerEventHandler PointerEntered
		{
			add;
			remove;
		}
		public extern event PointerEventHandler PointerExited
		{
			add;
			remove;
		}
		public extern event PointerEventHandler PointerMoved
		{
			add;
			remove;
		}
		public extern event PointerEventHandler PointerPressed
		{
			add;
			remove;
		}
		public extern event PointerEventHandler PointerReleased
		{
			add;
			remove;
		}
		public extern event PointerEventHandler PointerWheelChanged
		{
			add;
			remove;
		}
		public extern event RightTappedEventHandler RightTapped
		{
			add;
			remove;
		}
		public extern event TappedEventHandler Tapped
		{
			add;
			remove;
		}
		public extern bool AllowDrop
		{
			get;
			set;
		}
		public extern CacheMode CacheMode
		{
			get;
			set;
		}
		public extern RectangleGeometry Clip
		{
			get;
			set;
		}
		public extern Size DesiredSize
		{
			get;
		}
		public extern bool IsDoubleTapEnabled
		{
			get;
			set;
		}
		public extern bool IsHitTestVisible
		{
			get;
			set;
		}
		public extern bool IsHoldingEnabled
		{
			get;
			set;
		}
		public extern bool IsRightTapEnabled
		{
			get;
			set;
		}
		public extern bool IsTapEnabled
		{
			get;
			set;
		}
		public extern ManipulationModes ManipulationMode
		{
			get;
			set;
		}
		public extern double Opacity
		{
			get;
			set;
		}
		public extern IVectorView<Pointer> PointerCaptures
		{
			get;
		}
		public extern Projection Projection
		{
			get;
			set;
		}
		public extern Size RenderSize
		{
			get;
		}
		public extern Transform RenderTransform
		{
			get;
			set;
		}
		public extern Point RenderTransformOrigin
		{
			get;
			set;
		}
		public extern TransitionCollection Transitions
		{
			get;
			set;
		}
		public extern bool UseLayoutRounding
		{
			get;
			set;
		}
		public extern Visibility Visibility
		{
			get;
			set;
		}
		public static extern DependencyProperty AllowDropProperty
		{
			get;
		}
		public static extern DependencyProperty CacheModeProperty
		{
			get;
		}
		public static extern DependencyProperty ClipProperty
		{
			get;
		}
		public static extern RoutedEvent DoubleTappedEvent
		{
			get;
		}
		public static extern RoutedEvent DragEnterEvent
		{
			get;
		}
		public static extern RoutedEvent DragLeaveEvent
		{
			get;
		}
		public static extern RoutedEvent DragOverEvent
		{
			get;
		}
		public static extern RoutedEvent DropEvent
		{
			get;
		}
		public static extern RoutedEvent HoldingEvent
		{
			get;
		}
		public static extern DependencyProperty IsDoubleTapEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsHitTestVisibleProperty
		{
			get;
		}
		public static extern DependencyProperty IsHoldingEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsRightTapEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsTapEnabledProperty
		{
			get;
		}
		public static extern RoutedEvent KeyDownEvent
		{
			get;
		}
		public static extern RoutedEvent KeyUpEvent
		{
			get;
		}
		public static extern RoutedEvent ManipulationCompletedEvent
		{
			get;
		}
		public static extern RoutedEvent ManipulationDeltaEvent
		{
			get;
		}
		public static extern RoutedEvent ManipulationInertiaStartingEvent
		{
			get;
		}
		public static extern DependencyProperty ManipulationModeProperty
		{
			get;
		}
		public static extern RoutedEvent ManipulationStartedEvent
		{
			get;
		}
		public static extern RoutedEvent ManipulationStartingEvent
		{
			get;
		}
		public static extern DependencyProperty OpacityProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public static extern RoutedEvent PointerCanceledEvent
		{
			get;
		}
		public static extern RoutedEvent PointerCaptureLostEvent
		{
			get;
		}
		public static extern DependencyProperty PointerCapturesProperty
		{
			get;
		}
		public static extern RoutedEvent PointerEnteredEvent
		{
			get;
		}
		public static extern RoutedEvent PointerExitedEvent
		{
			get;
		}
		public static extern RoutedEvent PointerMovedEvent
		{
			get;
		}
		public static extern RoutedEvent PointerPressedEvent
		{
			get;
		}
		public static extern RoutedEvent PointerReleasedEvent
		{
			get;
		}
		public static extern RoutedEvent PointerWheelChangedEvent
		{
			get;
		}
		public static extern DependencyProperty ProjectionProperty
		{
			get;
		}
		public static extern DependencyProperty RenderTransformOriginProperty
		{
			get;
		}
		public static extern DependencyProperty RenderTransformProperty
		{
			get;
		}
		public static extern RoutedEvent RightTappedEvent
		{
			get;
		}
		public static extern RoutedEvent TappedEvent
		{
			get;
		}
		public static extern DependencyProperty TransitionsProperty
		{
			get;
		}
		public static extern DependencyProperty UseLayoutRoundingProperty
		{
			get;
		}
		public static extern DependencyProperty VisibilityProperty
		{
			get;
		}
		public extern void Measure([In] Size availableSize);
		public extern void Arrange([In] Rect finalRect);
		public extern bool CapturePointer([In] Pointer value);
		public extern void ReleasePointerCapture([In] Pointer value);
		public extern void ReleasePointerCaptures();
		public extern void AddHandler([In] RoutedEvent routedEvent, [In] object handler, [In] bool handledEventsToo);
		public extern void RemoveHandler([In] RoutedEvent routedEvent, [In] object handler);
		public extern GeneralTransform TransformToVisual([In] UIElement visual);
		public extern void InvalidateMeasure();
		public extern void InvalidateArrange();
		public extern void UpdateLayout();
		protected virtual extern AutomationPeer OnCreateAutomationPeer();
		protected virtual extern void OnDisconnectVisualChildren();
		protected virtual extern IIterable<IIterable<Point>> FindSubElementsForTouchTargeting([In] Point point, [In] Rect boundingRect);
	}
}
