using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(DataProviderRequest)), Guid(3954995543u, 54216, 18394, 172, 222, 248, 35, 136, 213, 247, 22), Version(100794368u)]
	internal interface IDataProviderRequest
	{
		DateTime Deadline
		{
			get;
		}
		string FormatId
		{
			get;
		}
		DataProviderDeferral GetDeferral();
		void SetData([HasVariant] [In] object value);
	}
}
