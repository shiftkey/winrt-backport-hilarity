using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[ExclusiveTo(typeof(InkRecognitionResult)), Guid(910563988u, 20584, 16623, 138, 5, 44, 47, 182, 9, 8, 162), Version(100794368u)]
	internal interface IInkRecognitionResult
	{
		Rect BoundingRect
		{
			get;
		}
		IVectorView<string> GetTextCandidates();
		IVectorView<InkStroke> GetStrokes();
	}
}
