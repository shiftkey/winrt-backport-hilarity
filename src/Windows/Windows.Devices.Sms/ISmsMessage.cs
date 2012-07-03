using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Guid(3980156456u, 27012, 19207, 129, 29, 141, 89, 6, 237, 60, 234), Version(100794368u)]
	public interface ISmsMessage
	{
		uint Id
		{
			get;
		}
		SmsMessageClass MessageClass
		{
			get;
		}
	}
}
