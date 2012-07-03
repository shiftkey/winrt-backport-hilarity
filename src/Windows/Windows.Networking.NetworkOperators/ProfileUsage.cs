using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[Version(100794368u)]
	public struct ProfileUsage
	{
		public uint UsageInMegabytes;
		public DateTime LastSyncTime;
	}
}
