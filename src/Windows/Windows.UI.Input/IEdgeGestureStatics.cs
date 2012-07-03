using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(EdgeGesture)), Guid(3161097497u, 6382, 16451, 152, 57, 79, 197, 132, 214, 10, 20), Version(100794368u)]
	internal interface IEdgeGestureStatics
	{
		EdgeGesture GetForCurrentView();
	}
}
