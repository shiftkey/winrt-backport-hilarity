using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[Guid(3891058464u, 62196, 18989, 146, 14, 23, 10, 47, 72, 42, 39), Version(100794368u)]
	public delegate void DataProviderHandler([In] DataProviderRequest request);
}
