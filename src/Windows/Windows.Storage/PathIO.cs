using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPathIOStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class PathIO
	{
		[Overload("ReadTextAsync")]
		public static extern IAsyncOperation<string> ReadTextAsync([In] string absolutePath);
		[Overload("ReadTextWithEncodingAsync")]
		public static extern IAsyncOperation<string> ReadTextAsync([In] string absolutePath, [In] UnicodeEncoding encoding);
		[Overload("WriteTextAsync")]
		public static extern IAsyncAction WriteTextAsync([In] string absolutePath, [In] string contents);
		[Overload("WriteTextWithEncodingAsync")]
		public static extern IAsyncAction WriteTextAsync([In] string absolutePath, [In] string contents, [In] UnicodeEncoding encoding);
		[Overload("AppendTextAsync")]
		public static extern IAsyncAction AppendTextAsync([In] string absolutePath, [In] string contents);
		[Overload("AppendTextWithEncodingAsync")]
		public static extern IAsyncAction AppendTextAsync([In] string absolutePath, [In] string contents, [In] UnicodeEncoding encoding);
		[Overload("ReadLinesAsync")]
		public static extern IAsyncOperation<IVector<string>> ReadLinesAsync([In] string absolutePath);
		[Overload("ReadLinesWithEncodingAsync")]
		public static extern IAsyncOperation<IVector<string>> ReadLinesAsync([In] string absolutePath, [In] UnicodeEncoding encoding);
		[Overload("WriteLinesAsync")]
		public static extern IAsyncAction WriteLinesAsync([In] string absolutePath, [In] IIterable<string> lines);
		[Overload("WriteLinesWithEncodingAsync")]
		public static extern IAsyncAction WriteLinesAsync([In] string absolutePath, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
		[Overload("AppendLinesAsync")]
		public static extern IAsyncAction AppendLinesAsync([In] string absolutePath, [In] IIterable<string> lines);
		[Overload("AppendLinesWithEncodingAsync")]
		public static extern IAsyncAction AppendLinesAsync([In] string absolutePath, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
		public static extern IAsyncOperation<IBuffer> ReadBufferAsync([In] string absolutePath);
		public static extern IAsyncAction WriteBufferAsync([In] string absolutePath, [In] IBuffer buffer);
		public static extern IAsyncAction WriteBytesAsync([In] string absolutePath, [In] byte[] buffer);
	}
}
