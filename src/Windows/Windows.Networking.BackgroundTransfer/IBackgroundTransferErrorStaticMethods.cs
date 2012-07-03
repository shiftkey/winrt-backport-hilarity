using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Web;
namespace Windows.Networking.BackgroundTransfer
{
	[ExclusiveTo(typeof(BackgroundTransferError)), Guid(2865969924u, 4498, 19444, 139, 104, 57, 197, 173, 210, 68, 226), Version(100794368u)]
	internal interface IBackgroundTransferErrorStaticMethods
	{
		WebErrorStatus GetStatus([In] int hresult);
	}
}
