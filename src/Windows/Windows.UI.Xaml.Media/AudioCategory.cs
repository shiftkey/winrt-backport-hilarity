using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Version(100794368u), WebHostHidden]
	public enum AudioCategory
	{
		Other,
		ForegroundOnlyMedia,
		BackgroundCapableMedia,
		Communications,
		Alerts,
		SoundEffects,
		GameEffects,
		GameMedia
	}
}
