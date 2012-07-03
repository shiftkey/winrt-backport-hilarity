using System;
using Windows.Devices.Sms;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class NetworkOperatorNotificationEventDetails : INetworkOperatorNotificationEventDetails
	{
		public extern byte EncodingType
		{
			get;
		}
		public extern string Message
		{
			get;
		}
		public extern string NetworkAccountId
		{
			get;
		}
		public extern NetworkOperatorEventMessageType NotificationType
		{
			get;
		}
		public extern string RuleId
		{
			get;
		}
		public extern ISmsMessage SmsMessage
		{
			get;
		}
	}
}
