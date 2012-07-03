using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(PathIO))]
	internal interface IPathIOStatics
	{
		[Overload("ReadTextAsync")]
		IAsyncOperation<string> ReadTextAsync([In] string absolutePath);
		[Overload("ReadTextWithEncodingAsync")]
		IAsyncOperation<string> ReadTextAsync([In] string absolutePath, [In] UnicodeEncoding encoding);
		[Overload("WriteTextAsync")]
		IAsyncAction WriteTextAsync([In] string absolutePath, [In] string contents);
		[Overload("WriteTextWithEncodingAsync")]
		IAsyncAction WriteTextAsync([In] string absolutePath, [In] string contents, [In] UnicodeEncoding encoding);
		[Overload("AppendTextAsync")]
		IAsyncAction AppendTextAsync([In] string absolutePath, [In] string contents);
		[Overload("AppendTextWithEncodingAsync")]
		IAsyncAction AppendTextAsync([In] string absolutePath, [In] string contents, [In] UnicodeEncoding encoding);
		[Overload("ReadLinesAsync")]
		IAsyncOperation<IVector<string>> ReadLinesAsync([In] string absolutePath);
		[Overload("ReadLinesWithEncodingAsync")]
		IAsyncOperation<IVector<string>> ReadLinesAsync([In] string absolutePath, [In] UnicodeEncoding encoding);
		[Overload("WriteLinesAsync")]
		IAsyncAction WriteLinesAsync([In] string absolutePath, [In] IIterable<string> lines);
		[Overload("WriteLinesWithEncodingAsync")]
		IAsyncAction WriteLinesAsync([In] string absolutePath, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
		[Overload("AppendLinesAsync")]
		IAsyncAction AppendLinesAsync([In] string absolutePath, [In] IIterable<string> lines);
		[Overload("AppendLinesWithEncodingAsync")]
		IAsyncAction AppendLinesAsync([In] string absolutePath, [In] IIterable<string> lines, [In] UnicodeEncoding encoding);
		IAsyncOperation<IBuffer> ReadBufferAsync([In] string absolutePath);
		IAsyncAction WriteBufferAsync([In] string absolutePath, [In] IBuffer buffer);
		IAsyncAction WriteBytesAsync([In] string absolutePath, [In] byte[] buffer);
	}
}
