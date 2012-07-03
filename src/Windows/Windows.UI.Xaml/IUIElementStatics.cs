using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(UIElement)), Guid(1490245435u, 62764, 17854, 152, 139, 165, 134, 149, 100, 135, 60), Version(100794368u), WebHostHidden]
	internal interface IUIElementStatics
	{
		DependencyProperty AllowDropProperty
		{
			get;
		}
		DependencyProperty CacheModeProperty
		{
			get;
		}
		DependencyProperty ClipProperty
		{
			get;
		}
		RoutedEvent DoubleTappedEvent
		{
			get;
		}
		RoutedEvent DragEnterEvent
		{
			get;
		}
		RoutedEvent DragLeaveEvent
		{
			get;
		}
		RoutedEvent DragOverEvent
		{
			get;
		}
		RoutedEvent DropEvent
		{
			get;
		}
		RoutedEvent HoldingEvent
		{
			get;
		}
		DependencyProperty IsDoubleTapEnabledProperty
		{
			get;
		}
		DependencyProperty IsHitTestVisibleProperty
		{
			get;
		}
		DependencyProperty IsHoldingEnabledProperty
		{
			get;
		}
		DependencyProperty IsRightTapEnabledProperty
		{
			get;
		}
		DependencyProperty IsTapEnabledProperty
		{
			get;
		}
		RoutedEvent KeyDownEvent
		{
			get;
		}
		RoutedEvent KeyUpEvent
		{
			get;
		}
		RoutedEvent ManipulationCompletedEvent
		{
			get;
		}
		RoutedEvent ManipulationDeltaEvent
		{
			get;
		}
		RoutedEvent ManipulationInertiaStartingEvent
		{
			get;
		}
		DependencyProperty ManipulationModeProperty
		{
			get;
		}
		RoutedEvent ManipulationStartedEvent
		{
			get;
		}
		RoutedEvent ManipulationStartingEvent
		{
			get;
		}
		DependencyProperty OpacityProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		RoutedEvent PointerCanceledEvent
		{
			get;
		}
		RoutedEvent PointerCaptureLostEvent
		{
			get;
		}
		DependencyProperty PointerCapturesProperty
		{
			get;
		}
		RoutedEvent PointerEnteredEvent
		{
			get;
		}
		RoutedEvent PointerExitedEvent
		{
			get;
		}
		RoutedEvent PointerMovedEvent
		{
			get;
		}
		RoutedEvent PointerPressedEvent
		{
			get;
		}
		RoutedEvent PointerReleasedEvent
		{
			get;
		}
		RoutedEvent PointerWheelChangedEvent
		{
			get;
		}
		DependencyProperty ProjectionProperty
		{
			get;
		}
		DependencyProperty RenderTransformOriginProperty
		{
			get;
		}
		DependencyProperty RenderTransformProperty
		{
			get;
		}
		RoutedEvent RightTappedEvent
		{
			get;
		}
		RoutedEvent TappedEvent
		{
			get;
		}
		DependencyProperty TransitionsProperty
		{
			get;
		}
		DependencyProperty UseLayoutRoundingProperty
		{
			get;
		}
		DependencyProperty VisibilityProperty
		{
			get;
		}
	}
}
