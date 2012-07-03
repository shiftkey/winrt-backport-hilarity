using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Guid(2421821409u, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218), Version(100794368u)]
	public interface IRandomAccessStream : IClosable, IInputStream, IOutputStream
	{
		bool CanRead
		{
			get;
		}
		bool CanWrite
		{
			get;
		}
		ulong Position
		{
			get;
		}
		ulong Size
		{
			get;
			set;
		}
		IInputStream GetInputStreamAt([In] ulong position);
		IOutputStream GetOutputStreamAt([In] ulong position);
		void Seek([In] ulong position);
		IRandomAccessStream CloneStream();
	}
}
