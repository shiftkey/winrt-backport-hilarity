using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[ExclusiveTo(typeof(OnlineIdServiceTicket)), Guid(3378271359u, 55169, 19092, 172, 184, 197, 152, 116, 35, 140, 38), Version(100794368u)]
	internal interface IOnlineIdServiceTicket
	{
		int ErrorCode
		{
			get;
		}
		OnlineIdServiceTicketRequest Request
		{
			get;
		}
		string Value
		{
			get;
		}
	}
}
