using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISmsTextMessageStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class SmsTextMessage : ISmsTextMessage, ISmsMessage
	{
		public extern string Body
		{
			get;
			set;
		}
		public extern SmsEncoding Encoding
		{
			get;
			set;
		}
		public extern string From
		{
			get;
			set;
		}
		public extern uint PartCount
		{
			get;
		}
		public extern uint PartNumber
		{
			get;
		}
		public extern uint PartReferenceId
		{
			get;
		}
		public extern DateTime Timestamp
		{
			get;
		}
		public extern string To
		{
			get;
			set;
		}
		public extern uint Id
		{
			get;
		}
		public extern SmsMessageClass MessageClass
		{
			get;
		}
		public extern SmsTextMessage();
		public extern IVectorView<ISmsBinaryMessage> ToBinaryMessages([In] SmsDataFormat format);
		public static extern SmsTextMessage FromBinaryMessage([In] SmsBinaryMessage binaryMessage);
		public static extern SmsTextMessage FromBinaryData([In] SmsDataFormat format, [In] byte[] value);
	}
}
