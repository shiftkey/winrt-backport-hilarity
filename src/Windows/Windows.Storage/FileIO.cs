using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IFileIOStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class FileIO
	{
		[Overload("ReadTextAsync")]
		public static extern IAsyncOperation<string> ReadTextAsync([In] IStorageFile file);
		[Overload("ReadTextWithEncodingAsync")]
		public static extern IAsyncOperation<string> ReadTextAsync([In] IStorageFile file, [In] UnicodeEncoding encoding);
		[Overload("WriteTextAsync")]
		public static extern IAsyncAction WriteTextAsync([In] IStorageFile file, [In] string contents);
		[Overload("WriteTextWithEncodingAsync")]
		public static extern IAsyncAction WriteTextAsync([In] IStorageFile file, [In] string contents, [In] UnicodeEncoding encoding);
		[Overload("AppendTextAsync")]
		public static extern IAsyncAction AppendTextAsync([In] IStorageFile file, [In] string contents);
		[Overload("AppendTextWithEncodingAsync")]
		public static extern IAsyncAction AppendTextAsync([In] IStorageFile file, [In] string contents, [In] UnicodeEncoding encoding);
		[Overload("ReadLinesAsync")]
		public static extern IAsyncOperation<IVector<string>> ReadLinesAsync([In] IStorageFile file);
		[Overload("ReadLinesWithEncodingAsync")]
		public static extern IAsyncOperation<IVector<string>> ReadLinesAsync([In] IStorageFile file, [In] UnicodeEncoding encoding);
		[Overload("WriteLinesAsync")]
		public static extern IAsyncAction WriteLinesAsync([In] IStorageFile file, [In] IIterable<string> lines);
		[Overload("WriteLinesWithEncodingAsync")]
		public static extern IAsyncAction WriteLinesAsync([In] IStorageFile file, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
		[Overload("AppendLinesAsync")]
		public static extern IAsyncAction AppendLinesAsync([In] IStorageFile file, [In] IIterable<string> lines);
		[Overload("AppendLinesWithEncodingAsync")]
		public static extern IAsyncAction AppendLinesAsync([In] IStorageFile file, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
		public static extern IAsyncOperation<IBuffer> ReadBufferAsync([In] IStorageFile file);
		public static extern IAsyncAction WriteBufferAsync([In] IStorageFile file, [In] IBuffer buffer);
		public static extern IAsyncAction WriteBytesAsync([In] IStorageFile file, [In] byte[] buffer);
	}
}
