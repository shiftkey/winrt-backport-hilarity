using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sms
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class SmsReceivedEventDetails : ISmsReceivedEventDetails
	{
		public extern string DeviceId
		{
			get;
		}
		public extern uint MessageIndex
		{
			get;
		}
	}
}
