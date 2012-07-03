using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(DataRequest)), Guid(1128377915u, 64530, 20051, 140, 2, 172, 113, 76, 65, 90, 39), Version(100794368u)]
	internal interface IDataRequest
	{
		DataPackage Data
		{
			get;
			set;
		}
		DateTime Deadline
		{
			get;
		}
		void FailWithDisplayText([In] string value);
		DataRequestDeferral GetDeferral();
	}
}
