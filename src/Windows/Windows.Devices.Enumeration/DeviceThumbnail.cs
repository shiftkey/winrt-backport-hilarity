using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Devices.Enumeration
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DeviceThumbnail : IRandomAccessStreamWithContentType, IRandomAccessStream, IClosable, IInputStream, IOutputStream, IContentTypeProvider
	{
		public extern bool CanRead
		{
			get;
		}
		public extern bool CanWrite
		{
			get;
		}
		public extern ulong Position
		{
			get;
		}
		public extern ulong Size
		{
			get;
			set;
		}
		public extern string ContentType
		{
			get;
		}
		public extern IInputStream GetInputStreamAt([In] ulong position);
		public extern IOutputStream GetOutputStreamAt([In] ulong position);
		public extern void Seek([In] ulong position);
		public extern IRandomAccessStream CloneStream();
		public extern void Close();
		public extern IAsyncOperationWithProgress<IBuffer, uint> ReadAsync([In] IBuffer buffer, [In] uint count, [In] InputStreamOptions options);
		public extern IAsyncOperationWithProgress<uint, uint> WriteAsync([In] IBuffer buffer);
		public extern IAsyncOperation<bool> FlushAsync();
	}
}
