using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.None), Version(100794368u)]
	public sealed class InkRecognitionResult : IInkRecognitionResult
	{
		public extern Rect BoundingRect
		{
			get;
		}
		public extern IVectorView<string> GetTextCandidates();
		public extern IVectorView<InkStroke> GetStrokes();
	}
}
