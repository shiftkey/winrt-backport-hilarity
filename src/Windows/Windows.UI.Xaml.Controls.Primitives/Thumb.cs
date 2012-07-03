using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IThumbStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class Thumb : Control, IThumb
	{
		public extern event DragCompletedEventHandler DragCompleted
		{
			add;
			remove;
		}
		public extern event DragDeltaEventHandler DragDelta
		{
			add;
			remove;
		}
		public extern event DragStartedEventHandler DragStarted
		{
			add;
			remove;
		}
		public extern bool IsDragging
		{
			get;
		}
		public static extern DependencyProperty IsDraggingProperty
		{
			get;
		}
		public extern Thumb();
		public extern void CancelDrag();
	}
}
