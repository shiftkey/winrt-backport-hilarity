using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[ExclusiveTo(typeof(OnlineIdServiceTicketRequest)), Guid(3199928840u, 40563, 16503, 150, 20, 8, 97, 76, 11, 194, 69), Version(100794368u)]
	internal interface IOnlineIdServiceTicketRequestFactory
	{
		[Overload("CreateOnlineIdServiceTicketRequest")]
		OnlineIdServiceTicketRequest CreateOnlineIdServiceTicketRequest([In] string service, [In] string policy);
		[DefaultOverload, Overload("CreateOnlineIdServiceTicketRequestAdvanced")]
		OnlineIdServiceTicketRequest CreateOnlineIdServiceTicketRequest([In] string service);
	}
}
