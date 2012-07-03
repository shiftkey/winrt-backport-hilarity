using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Version(100794368u), WebHostHidden]
	public enum ScrollEventType
	{
		SmallDecrement,
		SmallIncrement,
		LargeDecrement,
		LargeIncrement,
		ThumbPosition,
		ThumbTrack,
		First,
		Last,
		EndScroll
	}
}
