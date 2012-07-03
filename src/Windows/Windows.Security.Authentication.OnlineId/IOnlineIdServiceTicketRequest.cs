using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[ExclusiveTo(typeof(OnlineIdServiceTicketRequest)), Guid(695485907u, 64355, 16693, 137, 9, 78, 53, 76, 6, 20, 102), Version(100794368u)]
	internal interface IOnlineIdServiceTicketRequest
	{
		string Policy
		{
			get;
		}
		string Service
		{
			get;
		}
	}
}
