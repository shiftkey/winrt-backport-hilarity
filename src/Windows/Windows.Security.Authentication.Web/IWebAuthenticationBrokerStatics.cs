using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.Web
{
	[ExclusiveTo(typeof(WebAuthenticationBroker)), Guid(789880602u, 58995, 16565, 188, 34, 32, 26, 104, 100, 163, 123), Version(100794368u)]
	internal interface IWebAuthenticationBrokerStatics
	{
		[DefaultOverload, Overload("AuthenticateWithCallbackUriAsync")]
		IAsyncOperation<WebAuthenticationResult> AuthenticateAsync([In] WebAuthenticationOptions options, [In] Uri requestUri, [In] Uri callbackUri);
		[DefaultOverload, Overload("AuthenticateWithoutCallbackUriAsync")]
		IAsyncOperation<WebAuthenticationResult> AuthenticateAsync([In] WebAuthenticationOptions options, [In] Uri requestUri);
		Uri GetCurrentApplicationCallbackUri();
	}
}
