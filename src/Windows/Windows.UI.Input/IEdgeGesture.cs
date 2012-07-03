using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(EdgeGesture)), Guid(1477268114u, 10929, 18858, 167, 240, 51, 189, 63, 141, 249, 241), Version(100794368u)]
	internal interface IEdgeGesture
	{
		event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Canceled;
		event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Completed;
		event TypedEventHandler<EdgeGesture, EdgeGestureEventArgs> Starting;
	}
}
