using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Guid(192599049u, 60461, 18382, 162, 83, 115, 43, 238, 235, 202, 205), Version(100794368u)]
	public delegate void SmsMessageReceivedEventHandler([In] SmsDevice sender, [In] SmsMessageReceivedEventArgs e);
}
