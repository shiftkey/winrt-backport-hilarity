using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class OnlineIdAuthenticator : IOnlineIdAuthenticator
	{
		public extern Guid ApplicationId
		{
			get;
			set;
		}
		public extern string AuthenticatedSafeCustomerId
		{
			get;
		}
		public extern bool CanSignOut
		{
			get;
		}
		public extern OnlineIdAuthenticator();
		[Overload("AuthenticateUserAsync")]
		public extern UserAuthenticationOperation AuthenticateUserAsync([In] OnlineIdServiceTicketRequest request);
		[DefaultOverload, Overload("AuthenticateUserAsyncAdvanced")]
		public extern UserAuthenticationOperation AuthenticateUserAsync([In] IIterable<OnlineIdServiceTicketRequest> requests, [In] CredentialPromptType credentialPromptType);
		public extern SignOutUserOperation SignOutUserAsync();
	}
}
