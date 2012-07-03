using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
	[ExclusiveTo(typeof(DataReader))]
	internal interface IDataReaderStatics
	{
		DataReader FromBuffer([In] IBuffer buffer);
	}
}
