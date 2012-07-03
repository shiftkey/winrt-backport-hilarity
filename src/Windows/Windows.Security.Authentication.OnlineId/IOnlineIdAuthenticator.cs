using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[ExclusiveTo(typeof(OnlineIdAuthenticator)), Guid(2684614026u, 10667, 18455, 184, 132, 215, 81, 109, 173, 24, 185), Version(100794368u)]
	internal interface IOnlineIdAuthenticator
	{
		Guid ApplicationId
		{
			get;
			set;
		}
		string AuthenticatedSafeCustomerId
		{
			get;
		}
		bool CanSignOut
		{
			get;
		}
		[Overload("AuthenticateUserAsync")]
		UserAuthenticationOperation AuthenticateUserAsync([In] OnlineIdServiceTicketRequest request);
		[DefaultOverload, Overload("AuthenticateUserAsyncAdvanced")]
		UserAuthenticationOperation AuthenticateUserAsync([In] IIterable<OnlineIdServiceTicketRequest> requests, [In] CredentialPromptType credentialPromptType);
		SignOutUserOperation SignOutUserAsync();
	}
}
