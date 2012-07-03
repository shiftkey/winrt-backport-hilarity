using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[ExclusiveTo(typeof(InkManager)), Guid(1195668349u, 26395, 16739, 156, 149, 78, 141, 122, 3, 95, 225), Version(100794368u)]
	internal interface IInkManager : IInkStrokeContainer, IInkRecognizerContainer
	{
		InkManipulationMode Mode
		{
			get;
			set;
		}
		void ProcessPointerDown([In] PointerPoint pointerPoint);
		[return: Variant]
		object ProcessPointerUpdate([In] PointerPoint pointerPoint);
		Rect ProcessPointerUp([In] PointerPoint pointerPoint);
		void SetDefaultDrawingAttributes([In] InkDrawingAttributes drawingAttributes);
		[DefaultOverload, Overload("RecognizeAsync2")]
		IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync([In] InkRecognitionTarget recognitionTarget);
	}
}
