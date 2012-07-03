using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[Version(100794368u)]
	public enum CrossSlidingState
	{
		Started,
		Dragging,
		Selecting,
		SelectSpeedBumping,
		SpeedBumping,
		Rearranging,
		Completed
	}
}
