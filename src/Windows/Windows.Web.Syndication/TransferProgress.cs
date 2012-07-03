using System;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[Version(100794368u)]
	public struct TransferProgress
	{
		public uint BytesSent;
		public uint TotalBytesToSend;
		public uint BytesRetrieved;
		public uint TotalBytesToRetrieve;
	}
}
