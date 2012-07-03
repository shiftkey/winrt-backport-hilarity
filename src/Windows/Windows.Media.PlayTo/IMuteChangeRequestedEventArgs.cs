using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(MuteChangeRequestedEventArgs)), Guid(3837064694u, 44831, 20254, 180, 55, 125, 163, 36, 0, 225, 212), Version(100794368u)]
	internal interface IMuteChangeRequestedEventArgs
	{
		bool Mute
		{
			get;
		}
	}
}
