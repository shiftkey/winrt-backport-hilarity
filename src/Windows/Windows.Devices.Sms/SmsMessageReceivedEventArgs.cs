using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Version(100794368u)]
	public sealed class SmsMessageReceivedEventArgs : ISmsMessageReceivedEventArgs
	{
		public extern SmsBinaryMessage BinaryMessage
		{
			get;
		}
		public extern SmsTextMessage TextMessage
		{
			get;
		}
	}
}
