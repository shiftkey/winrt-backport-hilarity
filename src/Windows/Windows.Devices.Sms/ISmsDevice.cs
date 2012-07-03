using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Guid(152539629u, 34603, 20204, 156, 114, 171, 17, 98, 123, 52, 236), Version(100794368u)]
	public interface ISmsDevice
	{
		event SmsDeviceStatusChangedEventHandler SmsDeviceStatusChanged;
		event SmsMessageReceivedEventHandler SmsMessageReceived;
		string AccountPhoneNumber
		{
			get;
		}
		CellularClass CellularClass
		{
			get;
		}
		SmsDeviceStatus DeviceStatus
		{
			get;
		}
		SmsDeviceMessageStore MessageStore
		{
			get;
		}
		SendSmsMessageOperation SendMessageAsync([In] ISmsMessage message);
		SmsEncodedLength CalculateLength([In] SmsTextMessage message);
	}
}
