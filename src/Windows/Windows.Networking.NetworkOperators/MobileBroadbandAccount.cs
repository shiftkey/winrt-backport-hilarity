using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[DualApiPartition(version = 100794368u), Static(typeof(IMobileBroadbandAccountStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class MobileBroadbandAccount : IMobileBroadbandAccount
	{
		public extern MobileBroadbandDeviceInformation CurrentDeviceInformation
		{
			get;
		}
		public extern MobileBroadbandNetwork CurrentNetwork
		{
			get;
		}
		public extern string NetworkAccountId
		{
			get;
		}
		public extern Guid ServiceProviderGuid
		{
			get;
		}
		public extern string ServiceProviderName
		{
			get;
		}
		public static extern IVectorView<string> AvailableNetworkAccountIds
		{
			get;
		}
		public static extern MobileBroadbandAccount CreateFromNetworkAccountId([In] string networkAccountId);
	}
}
