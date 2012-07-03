using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Guid(2552959330u, 15831, 17944, 175, 137, 12, 39, 45, 93, 6, 216), Version(100794368u)]
	public delegate void SmsDeviceStatusChangedEventHandler([In] SmsDevice sender);
}
