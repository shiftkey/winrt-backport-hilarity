using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.UI.Input.Inking
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.None), Threading(ThreadingModel.STA), Version(100794368u)]
	public sealed class InkManager : IInkManager, IInkStrokeContainer, IInkRecognizerContainer
	{
		public extern InkManipulationMode Mode
		{
			get;
			set;
		}
		public extern Rect BoundingRect
		{
			get;
		}
		public extern InkManager();
		public extern void ProcessPointerDown([In] PointerPoint pointerPoint);
		[return: Variant]
		public extern object ProcessPointerUpdate([In] PointerPoint pointerPoint);
		public extern Rect ProcessPointerUp([In] PointerPoint pointerPoint);
		public extern void SetDefaultDrawingAttributes([In] InkDrawingAttributes drawingAttributes);
		[DefaultOverload, Overload("RecognizeAsync2")]
		public extern IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync([In] InkRecognitionTarget recognitionTarget);
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
		public extern void SetDefaultRecognizer([In] InkRecognizer recognizer);
		public extern IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync([In] InkStrokeContainer strokeCollection, [In] InkRecognitionTarget recognitionTarget);
		public extern IVectorView<InkRecognizer> GetRecognizers();
	}
}
