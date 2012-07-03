using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[MarshalingBehavior(MarshalingType.Standard), Static(typeof(IEdgeGestureStatics), 100794368u), Threading(ThreadingModel.STA), Version(100794368u)]
	public sealed class EdgeGesture : IEdgeGesture
	{
		public extern event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Canceled
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Completed
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Starting
		{
			add;
			remove;
		}
		public static extern EdgeGesture GetForCurrentView();
	}
}
