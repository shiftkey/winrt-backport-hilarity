using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Store
{
	[ExclusiveTo(typeof(LicenseInformation)), Guid(2394414128u, 61808, 20181, 142, 33, 21, 22, 218, 63, 211, 103), Version(100794368u)]
	internal interface ILicenseInformation
	{
		event LicenseChangedEventHandler LicenseChanged;
		DateTime ExpirationDate
		{
			get;
		}
		bool IsActive
		{
			get;
		}
		bool IsTrial
		{
			get;
		}
		IMapView<string, ProductLicense> ProductLicenses
		{
			get;
		}
	}
}
