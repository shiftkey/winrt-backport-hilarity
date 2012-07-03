using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(GestureRecognizer)), Guid(3027908543u, 15723, 20360, 131, 232, 109, 203, 64, 18, 255, 176), Version(100794368u)]
	internal interface IGestureRecognizer
	{
		event TypedEventHandler<GestureRecognizer, CrossSlidingEventArgs> CrossSliding;
		event TypedEventHandler<GestureRecognizer, DraggingEventArgs> Dragging;
		event TypedEventHandler<GestureRecognizer, HoldingEventArgs> Holding;
		event TypedEventHandler<GestureRecognizer, ManipulationCompletedEventArgs> ManipulationCompleted;
		event TypedEventHandler<GestureRecognizer, ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting;
		event TypedEventHandler<GestureRecognizer, ManipulationStartedEventArgs> ManipulationStarted;
		event TypedEventHandler<GestureRecognizer, ManipulationUpdatedEventArgs> ManipulationUpdated;
		event TypedEventHandler<GestureRecognizer, RightTappedEventArgs> RightTapped;
		event TypedEventHandler<GestureRecognizer, TappedEventArgs> Tapped;
		bool AutoProcessInertia
		{
			get;
			set;
		}
		bool CrossSlideExact
		{
			get;
			set;
		}
		bool CrossSlideHorizontally
		{
			get;
			set;
		}
		CrossSlideThresholds CrossSlideThresholds
		{
			get;
			set;
		}
		GestureSettings GestureSettings
		{
			get;
			set;
		}
		float InertiaExpansion
		{
			get;
			set;
		}
		float InertiaExpansionDeceleration
		{
			get;
			set;
		}
		float InertiaRotationAngle
		{
			get;
			set;
		}
		float InertiaRotationDeceleration
		{
			get;
			set;
		}
		float InertiaTranslationDeceleration
		{
			get;
			set;
		}
		float InertiaTranslationDisplacement
		{
			get;
			set;
		}
		bool IsActive
		{
			get;
		}
		bool IsInertial
		{
			get;
		}
		bool ManipulationExact
		{
			get;
			set;
		}
		MouseWheelParameters MouseWheelParameters
		{
			get;
		}
		Point PivotCenter
		{
			get;
			set;
		}
		float PivotRadius
		{
			get;
			set;
		}
		bool ShowGestureFeedback
		{
			get;
			set;
		}
		bool CanBeDoubleTap([In] PointerPoint value);
		void ProcessDownEvent([In] PointerPoint value);
		void ProcessMoveEvents([In] IVector<PointerPoint> value);
		void ProcessUpEvent([In] PointerPoint value);
		void ProcessMouseWheelEvent([In] PointerPoint value, [In] bool isShiftKeyDown, [In] bool isControlKeyDown);
		void ProcessInertia();
		void CompleteGesture();
	}
}
