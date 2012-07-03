using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.None), Version(100794368u)]
	public sealed class InkStroke : IInkStroke
	{
		public extern Rect BoundingRect
		{
			get;
		}
		public extern InkDrawingAttributes DrawingAttributes
		{
			get;
			set;
		}
		public extern bool Recognized
		{
			get;
		}
		public extern bool Selected
		{
			get;
			set;
		}
		public extern IVectorView<InkStrokeRenderingSegment> GetRenderingSegments();
		public extern InkStroke Clone();
	}
}
