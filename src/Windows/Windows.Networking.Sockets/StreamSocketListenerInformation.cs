using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class StreamSocketListenerInformation : IStreamSocketListenerInformation
	{
		public extern string LocalPort
		{
			get;
		}
	}
}
