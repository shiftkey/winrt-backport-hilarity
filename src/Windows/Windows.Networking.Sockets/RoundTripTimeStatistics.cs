using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[Version(100794368u)]
	public struct RoundTripTimeStatistics
	{
		public uint Variance;
		public uint Max;
		public uint Min;
		public uint Sum;
	}
}
