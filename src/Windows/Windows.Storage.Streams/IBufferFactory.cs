using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	public interface IBufferFactory
	{
		Buffer Create([Range(0, 2147483647)] [In] uint capacity);
	}
}
