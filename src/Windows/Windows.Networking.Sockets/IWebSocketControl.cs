using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
namespace Windows.Networking.Sockets
{
	[Guid(784645571u, 55717, 17754, 152, 17, 222, 36, 212, 83, 55, 233), Version(100794368u)]
	public interface IWebSocketControl
	{
		uint OutboundBufferSizeInBytes
		{
			get;
			set;
		}
		PasswordCredential ProxyCredential
		{
			get;
			set;
		}
		PasswordCredential ServerCredential
		{
			get;
			set;
		}
		IVector<string> SupportedProtocols
		{
			get;
		}
	}
}
