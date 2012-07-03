using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[Activatable(typeof(IOnlineIdServiceTicketRequestFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class OnlineIdServiceTicketRequest : IOnlineIdServiceTicketRequest
	{
		public extern string Policy
		{
			get;
		}
		public extern string Service
		{
			get;
		}
		public extern OnlineIdServiceTicketRequest([In] string service, [In] string policy);
		public extern OnlineIdServiceTicketRequest([In] string service);
	}
}
