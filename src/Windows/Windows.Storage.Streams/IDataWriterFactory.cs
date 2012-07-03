using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[ExclusiveTo(typeof(DataWriter)), Guid(864839618u, 35716, 19499, 156, 80, 123, 135, 103, 132, 122, 31), Version(100794368u)]
	internal interface IDataWriterFactory
	{
		DataWriter CreateDataWriter([In] IOutputStream outputStream);
	}
}
