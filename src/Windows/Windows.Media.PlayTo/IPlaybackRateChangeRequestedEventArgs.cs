using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(PlaybackRateChangeRequestedEventArgs)), Guid(257319342u, 11400, 19658, 133, 64, 213, 134, 9, 93, 19, 165), Version(100794368u)]
	internal interface IPlaybackRateChangeRequestedEventArgs
	{
		double Rate
		{
			get;
		}
	}
}
