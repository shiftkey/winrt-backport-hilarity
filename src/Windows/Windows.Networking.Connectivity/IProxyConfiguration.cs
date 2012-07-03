using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(ProxyConfiguration)), Guid(4013580468u, 36868, 19926, 183, 216, 179, 229, 2, 244, 170, 208), Version(100794368u)]
	internal interface IProxyConfiguration
	{
		bool CanConnectDirectly
		{
			get;
		}
		IVectorView<Uri> ProxyUris
		{
			get;
		}
	}
}
