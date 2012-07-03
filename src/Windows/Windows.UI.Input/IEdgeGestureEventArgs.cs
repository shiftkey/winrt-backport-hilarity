using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[ExclusiveTo(typeof(EdgeGestureEventArgs)), Guid(1157253668u, 11529, 17121, 139, 94, 54, 130, 8, 121, 106, 76), Version(100794368u)]
	internal interface IEdgeGestureEventArgs
	{
		EdgeGestureKind Kind
		{
			get;
		}
	}
}
