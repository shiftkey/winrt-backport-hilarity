using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[ExclusiveTo(typeof(InkStroke)), Guid(353652064u, 52451, 20431, 157, 82, 17, 81, 138, 182, 175, 212), Version(100794368u)]
	internal interface IInkStroke
	{
		Rect BoundingRect
		{
			get;
		}
		InkDrawingAttributes DrawingAttributes
		{
			get;
			set;
		}
		bool Recognized
		{
			get;
		}
		bool Selected
		{
			get;
			set;
		}
		IVectorView<InkStrokeRenderingSegment> GetRenderingSegments();
		InkStroke Clone();
	}
}
