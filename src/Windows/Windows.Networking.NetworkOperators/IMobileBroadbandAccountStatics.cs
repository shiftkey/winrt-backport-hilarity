using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(MobileBroadbandAccount)), Guid(2860469540u, 44993, 20424, 174, 154, 169, 23, 83, 16, 250, 173), Version(100794368u)]
	internal interface IMobileBroadbandAccountStatics
	{
		IVectorView<string> AvailableNetworkAccountIds
		{
			get;
		}
		MobileBroadbandAccount CreateFromNetworkAccountId([In] string networkAccountId);
	}
}
