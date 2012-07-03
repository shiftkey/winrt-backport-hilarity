using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.None), Version(100794368u)]
	public sealed class GestureRecognizer : IGestureRecognizer
	{
		public extern event TypedEventHandler<GestureRecognizer, CrossSlidingEventArgs> CrossSliding
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<GestureRecognizer, DraggingEventArgs> Dragging
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<GestureRecognizer, HoldingEventArgs> Holding
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<GestureRecognizer, ManipulationCompletedEventArgs> ManipulationCompleted
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<GestureRecognizer, ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<GestureRecognizer, ManipulationStartedEventArgs> ManipulationStarted
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<GestureRecognizer, ManipulationUpdatedEventArgs> ManipulationUpdated
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<GestureRecognizer, RightTappedEventArgs> RightTapped
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<GestureRecognizer, TappedEventArgs> Tapped
		{
			add;
			remove;
		}
		public extern bool AutoProcessInertia
		{
			get;
			set;
		}
		public extern bool CrossSlideExact
		{
			get;
			set;
		}
		public extern bool CrossSlideHorizontally
		{
			get;
			set;
		}
		public extern CrossSlideThresholds CrossSlideThresholds
		{
			get;
			set;
		}
		public extern GestureSettings GestureSettings
		{
			get;
			set;
		}
		public extern float InertiaExpansion
		{
			get;
			set;
		}
		public extern float InertiaExpansionDeceleration
		{
			get;
			set;
		}
		public extern float InertiaRotationAngle
		{
			get;
			set;
		}
		public extern float InertiaRotationDeceleration
		{
			get;
			set;
		}
		public extern float InertiaTranslationDeceleration
		{
			get;
			set;
		}
		public extern float InertiaTranslationDisplacement
		{
			get;
			set;
		}
		public extern bool IsActive
		{
			get;
		}
		public extern bool IsInertial
		{
			get;
		}
		public extern bool ManipulationExact
		{
			get;
			set;
		}
		public extern MouseWheelParameters MouseWheelParameters
		{
			get;
		}
		public extern Point PivotCenter
		{
			get;
			set;
		}
		public extern float PivotRadius
		{
			get;
			set;
		}
		public extern bool ShowGestureFeedback
		{
			get;
			set;
		}
		public extern GestureRecognizer();
		public extern bool CanBeDoubleTap([In] PointerPoint value);
		public extern void ProcessDownEvent([In] PointerPoint value);
		public extern void ProcessMoveEvents([In] IVector<PointerPoint> value);
		public extern void ProcessUpEvent([In] PointerPoint value);
		public extern void ProcessMouseWheelEvent([In] PointerPoint value, [In] bool isShiftKeyDown, [In] bool isControlKeyDown);
		public extern void ProcessInertia();
		public extern void CompleteGesture();
	}
}
