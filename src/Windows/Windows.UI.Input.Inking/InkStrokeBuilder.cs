using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.None), Threading(ThreadingModel.STA), Version(100794368u)]
	public sealed class InkStrokeBuilder : IInkStrokeBuilder
	{
		public extern InkStrokeBuilder();
		public extern void BeginStroke([In] PointerPoint pointerPoint);
		public extern PointerPoint AppendToStroke([In] PointerPoint pointerPoint);
		public extern InkStroke EndStroke([In] PointerPoint pointerPoint);
		public extern InkStroke CreateStroke([In] IIterable<Point> points);
		public extern void SetDefaultDrawingAttributes([In] InkDrawingAttributes drawingAttributes);
	}
}
