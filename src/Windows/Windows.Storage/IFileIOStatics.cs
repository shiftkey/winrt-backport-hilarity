using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(FileIO)), Guid(2289308139u, 32596, 18226, 165, 240, 94, 67, 227, 184, 194, 245), Version(100794368u)]
	internal interface IFileIOStatics
	{
		[Overload("ReadTextAsync")]
		IAsyncOperation<string> ReadTextAsync([In] IStorageFile file);
		[Overload("ReadTextWithEncodingAsync")]
		IAsyncOperation<string> ReadTextAsync([In] IStorageFile file, [In] UnicodeEncoding encoding);
		[Overload("WriteTextAsync")]
		IAsyncAction WriteTextAsync([In] IStorageFile file, [In] string contents);
		[Overload("WriteTextWithEncodingAsync")]
		IAsyncAction WriteTextAsync([In] IStorageFile file, [In] string contents, [In] UnicodeEncoding encoding);
		[Overload("AppendTextAsync")]
		IAsyncAction AppendTextAsync([In] IStorageFile file, [In] string contents);
		[Overload("AppendTextWithEncodingAsync")]
		IAsyncAction AppendTextAsync([In] IStorageFile file, [In] string contents, [In] UnicodeEncoding encoding);
		[Overload("ReadLinesAsync")]
		IAsyncOperation<IVector<string>> ReadLinesAsync([In] IStorageFile file);
		[Overload("ReadLinesWithEncodingAsync")]
		IAsyncOperation<IVector<string>> ReadLinesAsync([In] IStorageFile file, [In] UnicodeEncoding encoding);
		[Overload("WriteLinesAsync")]
		IAsyncAction WriteLinesAsync([In] IStorageFile file, [In] IIterable<string> lines);
		[Overload("WriteLinesWithEncodingAsync")]
		IAsyncAction WriteLinesAsync([In] IStorageFile file, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
		[Overload("AppendLinesAsync")]
		IAsyncAction AppendLinesAsync([In] IStorageFile file, [In] IIterable<string> lines);
		[Overload("AppendLinesWithEncodingAsync")]
		IAsyncAction AppendLinesAsync([In] IStorageFile file, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
		IAsyncOperation<IBuffer> ReadBufferAsync([In] IStorageFile file);
		IAsyncAction WriteBufferAsync([In] IStorageFile file, [In] IBuffer buffer);
		IAsyncAction WriteBytesAsync([In] IStorageFile file, [In] byte[] buffer);
	}
}
