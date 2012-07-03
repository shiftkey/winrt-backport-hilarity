using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.BackgroundTransfer
{
	[Version(100794368u)]
	public struct BackgroundUploadProgress
	{
		public ulong BytesReceived;
		public ulong BytesSent;
		public ulong TotalBytesToReceive;
		public ulong TotalBytesToSend;
		public BackgroundTransferStatus Status;
		public bool HasResponseChanged;
		public bool HasRestarted;
	}
}
