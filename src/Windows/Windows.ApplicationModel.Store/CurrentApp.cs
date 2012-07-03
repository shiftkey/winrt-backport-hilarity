using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Store
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICurrentApp), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class CurrentApp
	{
		public static extern Guid AppId
		{
			get;
		}
		public static extern LicenseInformation LicenseInformation
		{
			get;
		}
		public static extern Uri LinkUri
		{
			get;
		}
		public static extern IAsyncOperation<string> RequestAppPurchaseAsync([In] bool includeReceipt);
		public static extern IAsyncOperation<string> RequestProductPurchaseAsync([In] string productId, [In] bool includeReceipt);
		public static extern IAsyncOperation<ListingInformation> LoadListingInformationAsync();
		public static extern IAsyncOperation<string> GetAppReceiptAsync();
		public static extern IAsyncOperation<string> GetProductReceiptAsync([In] string productId);
	}
}
