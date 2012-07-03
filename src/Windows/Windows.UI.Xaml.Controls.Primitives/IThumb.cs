using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(Thumb)), Guid(3904025217u, 3434, 17871, 179, 51, 36, 2, 176, 55, 240, 153), Version(100794368u), WebHostHidden]
	internal interface IThumb
	{
		event DragCompletedEventHandler DragCompleted;
		event DragDeltaEventHandler DragDelta;
		event DragStartedEventHandler DragStarted;
		bool IsDragging
		{
			get;
		}
		void CancelDrag();
	}
}
