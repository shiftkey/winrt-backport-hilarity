using System;
using Windows.Devices.Sms;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(MobileBroadbandDeviceInformation)), Guid(3872424296u, 58241, 19566, 155, 232, 254, 21, 105, 105, 164, 70), Version(100794368u)]
	internal interface IMobileBroadbandDeviceInformation
	{
		CellularClass CellularClass
		{
			get;
		}
		MobileBroadbandRadioState CurrentRadioState
		{
			get;
		}
		string CustomDataClass
		{
			get;
		}
		DataClasses DataClasses
		{
			get;
		}
		string DeviceId
		{
			get;
		}
		MobileBroadbandDeviceType DeviceType
		{
			get;
		}
		string FirmwareInformation
		{
			get;
		}
		string Manufacturer
		{
			get;
		}
		string MobileEquipmentId
		{
			get;
		}
		string Model
		{
			get;
		}
		NetworkDeviceStatus NetworkDeviceStatus
		{
			get;
		}
		string SimIccId
		{
			get;
		}
		string SubscriberId
		{
			get;
		}
		IVectorView<string> TelephoneNumbers
		{
			get;
		}
	}
}
