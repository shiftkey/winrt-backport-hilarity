using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[ExclusiveTo(typeof(SmsDevice)), Guid(4169992170u, 55317, 19921, 162, 52, 69, 32, 206, 70, 4, 164), Version(100794368u)]
	internal interface ISmsDeviceStatics
	{
		string GetDeviceSelector();
		IAsyncOperation<SmsDevice> FromIdAsync([In] string deviceInstanceId);
		IAsyncOperation<SmsDevice> GetDefaultAsync();
	}
}
