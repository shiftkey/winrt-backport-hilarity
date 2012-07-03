using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Control)), Guid(2694222303u, 38948, 16894, 181, 48, 176, 216, 153, 14, 100, 193), Version(100794368u), WebHostHidden]
	internal interface IControlOverrides
	{
		void OnPointerEntered([In] PointerRoutedEventArgs e);
		void OnPointerPressed([In] PointerRoutedEventArgs e);
		void OnPointerMoved([In] PointerRoutedEventArgs e);
		void OnPointerReleased([In] PointerRoutedEventArgs e);
		void OnPointerExited([In] PointerRoutedEventArgs e);
		void OnPointerCaptureLost([In] PointerRoutedEventArgs e);
		void OnPointerCanceled([In] PointerRoutedEventArgs e);
		void OnPointerWheelChanged([In] PointerRoutedEventArgs e);
		void OnTapped([In] TappedRoutedEventArgs e);
		void OnDoubleTapped([In] DoubleTappedRoutedEventArgs e);
		void OnHolding([In] HoldingRoutedEventArgs e);
		void OnRightTapped([In] RightTappedRoutedEventArgs e);
		void OnManipulationStarting([In] ManipulationStartingRoutedEventArgs e);
		void OnManipulationInertiaStarting([In] ManipulationInertiaStartingRoutedEventArgs e);
		void OnManipulationStarted([In] ManipulationStartedRoutedEventArgs e);
		void OnManipulationDelta([In] ManipulationDeltaRoutedEventArgs e);
		void OnManipulationCompleted([In] ManipulationCompletedRoutedEventArgs e);
		void OnKeyUp([In] KeyRoutedEventArgs e);
		void OnKeyDown([In] KeyRoutedEventArgs e);
		void OnGotFocus([In] RoutedEventArgs e);
		void OnLostFocus([In] RoutedEventArgs e);
		void OnDragEnter([In] DragEventArgs e);
		void OnDragLeave([In] DragEventArgs e);
		void OnDragOver([In] DragEventArgs e);
		void OnDrop([In] DragEventArgs e);
	}
}
