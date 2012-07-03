using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Version(100794368u)]
	public enum SmsMessageFilter
	{
		All,
		Unread,
		Read,
		Sent,
		Draft
	}
}
