using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[DualApiPartition(version = 100794368u), Version(100794368u)]
	public sealed class MobileBroadbandAccountUpdatedEventArgs : IMobileBroadbandAccountUpdatedEventArgs
	{
		public extern bool HasDeviceInformationChanged
		{
			get;
		}
		public extern bool HasNetworkChanged
		{
			get;
		}
		public extern string NetworkAccountId
		{
			get;
		}
	}
}
