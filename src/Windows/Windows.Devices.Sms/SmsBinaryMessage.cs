using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SmsBinaryMessage : ISmsBinaryMessage, ISmsMessage
	{
		public extern SmsDataFormat Format
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
		public extern SmsBinaryMessage();
		public extern byte[] GetData();
		public extern void SetData([In] byte[] value);
	}
}
