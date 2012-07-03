using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Version(100794368u), WebHostHidden]
	public enum MediaElementState
	{
		Closed,
		Opening,
		Buffering,
		Playing,
		Paused,
		Stopped
	}
}
