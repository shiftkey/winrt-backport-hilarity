using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataProviderRequest : IDataProviderRequest
	{
		public extern DateTime Deadline
		{
			get;
		}
		public extern string FormatId
		{
			get;
		}
		public extern DataProviderDeferral GetDeferral();
		public extern void SetData([HasVariant] [In] object value);
	}
}
