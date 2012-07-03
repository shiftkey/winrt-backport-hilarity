using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[Version(100794368u)]
	public sealed class MuteChangeRequestedEventArgs : IMuteChangeRequestedEventArgs
	{
		public extern bool Mute
		{
			get;
		}
	}
}
