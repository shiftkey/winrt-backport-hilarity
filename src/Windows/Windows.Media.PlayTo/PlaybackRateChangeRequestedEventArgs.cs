using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[Version(100794368u)]
	public sealed class PlaybackRateChangeRequestedEventArgs : IPlaybackRateChangeRequestedEventArgs
	{
		public extern double Rate
		{
			get;
		}
	}
}
