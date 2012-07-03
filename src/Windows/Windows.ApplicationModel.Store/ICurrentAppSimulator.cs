using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.ApplicationModel.Store
{
	[ExclusiveTo(typeof(CurrentAppSimulator)), Guid(4051672497u, 29901, 18311, 151, 135, 25, 134, 110, 154, 85, 89), Version(100794368u)]
	internal interface ICurrentAppSimulator
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
		IAsyncAction ReloadSimulatorAsync([In] StorageFile simulatorSettingsFile);
	}
}
