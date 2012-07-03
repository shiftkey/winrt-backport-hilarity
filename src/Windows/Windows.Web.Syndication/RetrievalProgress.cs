using System;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[Version(100794368u)]
	public struct RetrievalProgress
	{
		public uint BytesRetrieved;
		public uint TotalBytesToRetrieve;
	}
}
