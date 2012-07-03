using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[DualApiPartition(version = 100794368u), Version(100794368u)]
	public sealed class MobileBroadbandAccountEventArgs : IMobileBroadbandAccountEventArgs
	{
		public extern string NetworkAccountId
		{
			get;
		}
	}
}
