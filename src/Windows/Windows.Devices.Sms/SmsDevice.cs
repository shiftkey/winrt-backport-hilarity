using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[DualApiPartition(version = 100794368u), Static(typeof(ISmsDeviceStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class SmsDevice : ISmsDevice
	{
		public extern event SmsDeviceStatusChangedEventHandler SmsDeviceStatusChanged
		{
			add;
			remove;
		}
		public extern event SmsMessageReceivedEventHandler SmsMessageReceived
		{
			add;
			remove;
		}
		public extern string AccountPhoneNumber
		{
			get;
		}
		public extern CellularClass CellularClass
		{
			get;
		}
		public extern SmsDeviceStatus DeviceStatus
		{
			get;
		}
		public extern SmsDeviceMessageStore MessageStore
		{
			get;
		}
		public extern SendSmsMessageOperation SendMessageAsync([In] ISmsMessage message);
		public extern SmsEncodedLength CalculateLength([In] SmsTextMessage message);
		public static extern string GetDeviceSelector();
		public static extern IAsyncOperation<SmsDevice> FromIdAsync([In] string deviceInstanceId);
		public static extern IAsyncOperation<SmsDevice> GetDefaultAsync();
	}
}
