using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.BackgroundTransfer
{
	[Version(100794368u)]
	public struct BackgroundDownloadProgress
	{
		public ulong BytesReceived;
		public ulong TotalBytesToReceive;
		public BackgroundTransferStatus Status;
		public bool HasResponseChanged;
		public bool HasRestarted;
	}
}
