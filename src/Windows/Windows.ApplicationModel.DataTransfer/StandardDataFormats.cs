using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IStandardDataFormatsStatics), 100794368u), Version(100794368u)]
	public static class StandardDataFormats
	{
		public static extern string Bitmap
		{
			get;
		}
		public static extern string Html
		{
			get;
		}
		public static extern string Rtf
		{
			get;
		}
		public static extern string StorageItems
		{
			get;
		}
		public static extern string Text
		{
			get;
		}
		public static extern string Uri
		{
			get;
		}
	}
}
