using System;
using Windows.Devices.Sms;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(NetworkOperatorNotificationEventDetails)), Guid(3160975825u, 33505, 17544, 159, 44, 18, 118, 194, 70, 143, 172), Version(100794368u)]
	internal interface INetworkOperatorNotificationEventDetails
	{
		byte EncodingType
		{
			get;
		}
		string Message
		{
			get;
		}
		string NetworkAccountId
		{
			get;
		}
		NetworkOperatorEventMessageType NotificationType
		{
			get;
		}
		string RuleId
		{
			get;
		}
		ISmsMessage SmsMessage
		{
			get;
		}
	}
}
