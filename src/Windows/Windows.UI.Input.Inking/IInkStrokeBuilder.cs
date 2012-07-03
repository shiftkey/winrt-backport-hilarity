using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[ExclusiveTo(typeof(InkStrokeBuilder)), Guid(2193347036u, 7267, 16860, 158, 7, 75, 74, 112, 206, 216, 1), Version(100794368u)]
	internal interface IInkStrokeBuilder
	{
		void BeginStroke([In] PointerPoint pointerPoint);
		PointerPoint AppendToStroke([In] PointerPoint pointerPoint);
		InkStroke EndStroke([In] PointerPoint pointerPoint);
		InkStroke CreateStroke([In] IIterable<Point> points);
		void SetDefaultDrawingAttributes([In] InkDrawingAttributes drawingAttributes);
	}
}
