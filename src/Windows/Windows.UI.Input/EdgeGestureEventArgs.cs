using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class EdgeGestureEventArgs : IEdgeGestureEventArgs
	{
		public extern EdgeGestureKind Kind
		{
			get;
		}
	}
}
