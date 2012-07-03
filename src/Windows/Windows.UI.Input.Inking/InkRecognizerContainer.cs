using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.None), Threading(ThreadingModel.STA), Version(100794368u)]
	public sealed class InkRecognizerContainer : IInkRecognizerContainer
	{
		public extern InkRecognizerContainer();
		public extern void SetDefaultRecognizer([In] InkRecognizer recognizer);
		public extern IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync([In] InkStrokeContainer strokeCollection, [In] InkRecognitionTarget recognitionTarget);
		public extern IVectorView<InkRecognizer> GetRecognizers();
	}
}
