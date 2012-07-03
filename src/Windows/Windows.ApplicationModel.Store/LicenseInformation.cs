using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Store
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class LicenseInformation : ILicenseInformation
	{
		public extern event LicenseChangedEventHandler LicenseChanged
		{
			add;
			remove;
		}
		public extern DateTime ExpirationDate
		{
			get;
		}
		public extern bool IsActive
		{
			get;
		}
		public extern bool IsTrial
		{
			get;
		}
		public extern IMapView<string, ProductLicense> ProductLicenses
		{
			get;
		}
	}
}
