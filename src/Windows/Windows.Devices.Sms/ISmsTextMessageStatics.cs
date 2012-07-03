using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[ExclusiveTo(typeof(SmsTextMessage)), Guid(2137572845u, 15564, 18339, 140, 85, 56, 13, 59, 1, 8, 146), Version(100794368u)]
	internal interface ISmsTextMessageStatics
	{
		SmsTextMessage FromBinaryMessage([In] SmsBinaryMessage binaryMessage);
		SmsTextMessage FromBinaryData([In] SmsDataFormat format, [In] byte[] value);
	}
}
