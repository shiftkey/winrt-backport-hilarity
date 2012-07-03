using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(DatagramSocket)), Guid(3922078446u, 5268, 18977, 187, 126, 133, 137, 252, 117, 29, 157), Version(100794368u)]
	internal interface IDatagramSocketStatics
	{
		[Overload("GetEndpointPairsAsync")]
		IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync([In] HostName remoteHostName, [In] string remoteServiceName);
		[Overload("GetEndpointPairsWithSortOptionsAsync")]
		IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync([In] HostName remoteHostName, [In] string remoteServiceName, [In] HostNameSortOptions sortOptions);
	}
}
