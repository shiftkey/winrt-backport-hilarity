using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.UI.Input.Inking
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.None), Threading(ThreadingModel.STA), Version(100794368u)]
	public sealed class InkStrokeContainer : IInkStrokeContainer
	{
		public extern Rect BoundingRect
		{
			get;
		}
		public extern InkStrokeContainer();
		public extern void AddStroke([In] InkStroke stroke);
		public extern Rect DeleteSelected();
		public extern Rect MoveSelected([In] Point translation);
		public extern Rect SelectWithPolyLine([In] IIterable<Point> polyline);
		public extern Rect SelectWithLine([In] Point from, [In] Point to);
		public extern void CopySelectedToClipboard();
		public extern Rect PasteFromClipboard([In] Point position);
		public extern bool CanPasteFromClipboard();
		public extern IAsyncActionWithProgress<ulong> LoadAsync([In] IInputStream inputStream);
		public extern IAsyncOperationWithProgress<uint, uint> SaveAsync([In] IOutputStream outputStream);
		public extern void UpdateRecognitionResults([In] IVectorView<InkRecognitionResult> recognitionResults);
		public extern IVectorView<InkStroke> GetStrokes();
		public extern IVectorView<InkRecognitionResult> GetRecognitionResults();
	}
}
