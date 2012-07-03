using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.UI.Input.Inking
{
	[Guid(581749702u, 64169, 20244, 182, 140, 246, 206, 230, 112, 174, 22), Version(100794368u)]
	public interface IInkStrokeContainer
	{
		Rect BoundingRect
		{
			get;
		}
		void AddStroke([In] InkStroke stroke);
		Rect DeleteSelected();
		Rect MoveSelected([In] Point translation);
		Rect SelectWithPolyLine([In] IIterable<Point> polyline);
		Rect SelectWithLine([In] Point from, [In] Point to);
		void CopySelectedToClipboard();
		Rect PasteFromClipboard([In] Point position);
		bool CanPasteFromClipboard();
		IAsyncActionWithProgress<ulong> LoadAsync([In] IInputStream inputStream);
		IAsyncOperationWithProgress<uint, uint> SaveAsync([In] IOutputStream outputStream);
		void UpdateRecognitionResults([In] IVectorView<InkRecognitionResult> recognitionResults);
		IVectorView<InkStroke> GetStrokes();
		IVectorView<InkRecognitionResult> GetRecognitionResults();
	}
}
