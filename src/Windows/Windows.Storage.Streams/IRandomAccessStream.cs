using System.Runtime.InteropServices;
using Windows.Foundation;

namespace Windows.Storage.Streams
{
	public interface IRandomAccessStream : IInputStream, IOutputStream
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
