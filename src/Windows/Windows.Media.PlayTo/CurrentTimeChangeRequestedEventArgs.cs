using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[Version(100794368u)]
	public sealed class CurrentTimeChangeRequestedEventArgs : ICurrentTimeChangeRequestedEventArgs
	{
		public extern TimeSpan Time
		{
			get;
		}
	}
}
