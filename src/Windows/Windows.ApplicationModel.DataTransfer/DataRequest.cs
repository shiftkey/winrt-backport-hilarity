using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataRequest : IDataRequest
	{
		public extern DataPackage Data
		{
			get;
			set;
		}
		public extern DateTime Deadline
		{
			get;
		}
		public extern void FailWithDisplayText([In] string value);
		public extern DataRequestDeferral GetDeferral();
	}
}
