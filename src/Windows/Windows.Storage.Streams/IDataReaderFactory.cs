using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
	[ExclusiveTo(typeof(DataReader))]
	internal interface IDataReaderFactory
	{
		DataReader CreateDataReader([In] IInputStream inputStream);
	}
}
