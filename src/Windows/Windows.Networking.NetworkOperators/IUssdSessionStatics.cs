using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(UssdSession)), Guid(798674818u, 4097, 19805, 191, 129, 42, 186, 27, 75, 228, 168), Version(100794368u)]
	internal interface IUssdSessionStatics
	{
		UssdSession CreateFromNetworkAccountId([In] string networkAccountId);
		UssdSession CreateFromNetworkInterfaceId([In] string networkInterfaceId);
	}
}
