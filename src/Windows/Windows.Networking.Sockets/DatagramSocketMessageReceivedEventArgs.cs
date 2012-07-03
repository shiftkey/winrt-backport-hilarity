using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Networking.Sockets
{
	[DualApiPartition(version = 100794368u), GCPressure(amount = GCPressureAmount.Medium), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DatagramSocketMessageReceivedEventArgs : IDatagramSocketMessageReceivedEventArgs
	{
		public extern HostName LocalAddress
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
		public extern DataReader GetDataReader();
		public extern IInputStream GetDataStream();
	}
}
