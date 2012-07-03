using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[ExclusiveTo(typeof(SmsMessageReceivedEventArgs)), Guid(149424792u, 47333, 16833, 163, 216, 211, 171, 250, 226, 38, 117), Version(100794368u)]
	internal interface ISmsMessageReceivedEventArgs
	{
		SmsBinaryMessage BinaryMessage
		{
			get;
		}
		SmsTextMessage TextMessage
		{
			get;
		}
	}
}
