using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Store
{
	[ExclusiveTo(typeof(CurrentApp)), Guid(3576545381u, 55871, 18053, 153, 94, 155, 72, 46, 181, 230, 3), Version(100794368u)]
	internal interface ICurrentApp
	{
		Guid AppId
		{
			get;
		}
		LicenseInformation LicenseInformation
		{
			get;
		}
		Uri LinkUri
		{
			get;
		}
		IAsyncOperation<string> RequestAppPurchaseAsync([In] bool includeReceipt);
		IAsyncOperation<string> RequestProductPurchaseAsync([In] string productId, [In] bool includeReceipt);
		IAsyncOperation<ListingInformation> LoadListingInformationAsync();
		IAsyncOperation<string> GetAppReceiptAsync();
		IAsyncOperation<string> GetProductReceiptAsync([In] string productId);
	}
}
