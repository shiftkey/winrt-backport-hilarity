using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[Guid(2806880817u, 32839, 18072, 169, 18, 248, 42, 80, 133, 1, 47), Version(100794368u)]
	public interface IInkRecognizerContainer
	{
		void SetDefaultRecognizer([In] InkRecognizer recognizer);
		IAsyncOperation<IVectorView<InkRecognitionResult>> RecognizeAsync([In] InkStrokeContainer strokeCollection, [In] InkRecognitionTarget recognitionTarget);
		IVectorView<InkRecognizer> GetRecognizers();
	}
}
