using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[Version(100794368u)]
	public enum SocketProtectionLevel
	{
		PlainSocket,
		Ssl,
		SslAllowNullEncryption
	}
}
