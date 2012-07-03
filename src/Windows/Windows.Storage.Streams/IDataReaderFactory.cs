using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[ExclusiveTo(typeof(DataReader)), Guid(3612506183u, 22490, 19989, 145, 76, 6, 128, 102, 153, 160, 152), Version(100794368u)]
	internal interface IDataReaderFactory
	{
		DataReader CreateDataReader([In] IInputStream inputStream);
	}
}
