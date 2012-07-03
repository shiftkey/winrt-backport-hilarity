using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class OnlineIdServiceTicket : IOnlineIdServiceTicket
	{
		public extern int ErrorCode
		{
			get;
		}
		public extern OnlineIdServiceTicketRequest Request
		{
			get;
		}
		public extern string Value
		{
			get;
		}
	}
}
