using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DatagramSocketInformation : IDatagramSocketInformation
	{
		public extern HostName LocalAddress
		{
			get;
		}
		public extern string LocalPort
		{
			get;
		}
		public extern HostName RemoteAddress
		{
			get;
		}
		public extern string RemotePort
		{
			get;
		}
	}
}
