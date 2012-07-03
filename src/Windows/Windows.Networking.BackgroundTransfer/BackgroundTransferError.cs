using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Web;
namespace Windows.Networking.BackgroundTransfer
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBackgroundTransferErrorStaticMethods), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class BackgroundTransferError
	{
		public static extern WebErrorStatus GetStatus([In] int hresult);
	}
}
