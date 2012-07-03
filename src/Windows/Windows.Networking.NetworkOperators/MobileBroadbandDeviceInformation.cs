using System;
using Windows.Devices.Sms;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[DualApiPartition(version = 100794368u), Version(100794368u)]
	public sealed class MobileBroadbandDeviceInformation : IMobileBroadbandDeviceInformation
	{
		public extern CellularClass CellularClass
		{
			get;
		}
		public extern MobileBroadbandRadioState CurrentRadioState
		{
			get;
		}
		public extern string CustomDataClass
		{
			get;
		}
		public extern DataClasses DataClasses
		{
			get;
		}
		public extern string DeviceId
		{
			get;
		}
		public extern MobileBroadbandDeviceType DeviceType
		{
			get;
		}
		public extern string FirmwareInformation
		{
			get;
		}
		public extern string Manufacturer
		{
			get;
		}
		public extern string MobileEquipmentId
		{
			get;
		}
		public extern string Model
		{
			get;
		}
		public extern NetworkDeviceStatus NetworkDeviceStatus
		{
			get;
		}
		public extern string SimIccId
		{
			get;
		}
		public extern string SubscriberId
		{
			get;
		}
		public extern IVectorView<string> TelephoneNumbers
		{
			get;
		}
	}
}
