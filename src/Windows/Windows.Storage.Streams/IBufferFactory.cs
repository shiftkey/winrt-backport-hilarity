using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Guid(1907331405u, 49423, 18507, 188, 80, 20, 188, 98, 59, 58, 39), Version(100794368u)]
	public interface IBufferFactory
	{
		Buffer Create([Range(0, 2147483647)] [In] uint capacity);
	}
}
