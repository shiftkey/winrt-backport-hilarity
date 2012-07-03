using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking
{
	[ExclusiveTo(typeof(EndpointPair)), Guid(3054098801u, 25824, 17451, 170, 111, 204, 140, 143, 24, 31, 120), Version(100794368u)]
	internal interface IEndpointPairFactory
	{
		EndpointPair CreateEndpointPair([In] HostName localHostName, [In] string localServiceName, [In] HostName remoteHostName, [In] string remoteServiceName);
	}
}
