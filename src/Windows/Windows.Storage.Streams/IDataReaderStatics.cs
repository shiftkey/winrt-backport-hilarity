using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[ExclusiveTo(typeof(DataReader)), Guid(301776840u, 63802, 18203, 177, 33, 243, 121, 227, 73, 49, 60), Version(100794368u)]
	internal interface IDataReaderStatics
	{
		DataReader FromBuffer([In] IBuffer buffer);
	}
}
