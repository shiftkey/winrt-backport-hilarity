using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[ExclusiveTo(typeof(DataWriter))]
	internal interface IDataWriterFactory
	{
		DataWriter CreateDataWriter([In] IOutputStream outputStream);
	}
}
