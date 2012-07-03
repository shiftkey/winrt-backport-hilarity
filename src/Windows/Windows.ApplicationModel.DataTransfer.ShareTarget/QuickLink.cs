using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class QuickLink : IQuickLink
	{
		public extern string Id
		{
			get;
			set;
		}
		public extern IVector<string> SupportedDataFormats
		{
			get;
		}
		public extern IVector<string> SupportedFileTypes
		{
			get;
		}
		public extern RandomAccessStreamReference Thumbnail
		{
			get;
			set;
		}
		public extern string Title
		{
			get;
			set;
		}
		public extern QuickLink();
	}
}
