using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.ExchangeActiveSyncProvisioning
{
	[ExclusiveTo(typeof(EasClientDeviceInformation)), Guid(1423956353u, 6504, 19619, 185, 88, 229, 149, 209, 101, 5, 235), Version(100794368u)]
	internal interface IEasClientDeviceInformation
	{
		string FriendlyName
		{
			get;
		}
		Guid Id
		{
			get;
		}
		string OperatingSystem
		{
			get;
		}
		string SystemManufacturer
		{
			get;
		}
		string SystemProductName
		{
			get;
		}
		string SystemSku
		{
			get;
		}
	}
}
