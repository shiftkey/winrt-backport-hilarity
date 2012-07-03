using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Version(100794368u)]
	public enum SmsDataFormat
	{
		Unknown,
		CdmaSubmit,
		GsmSubmit,
		CdmaDeliver,
		GsmDeliver
	}
}
