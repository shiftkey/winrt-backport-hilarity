using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.Web
{
	[Static(typeof(IWebAuthenticationBrokerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class WebAuthenticationBroker
	{
		[DefaultOverload, Overload("AuthenticateWithCallbackUriAsync")]
		public static extern IAsyncOperation<WebAuthenticationResult> AuthenticateAsync([In] WebAuthenticationOptions options, [In] Uri requestUri, [In] Uri callbackUri);
		[DefaultOverload, Overload("AuthenticateWithoutCallbackUriAsync")]
		public static extern IAsyncOperation<WebAuthenticationResult> AuthenticateAsync([In] WebAuthenticationOptions options, [In] Uri requestUri);
		public static extern Uri GetCurrentApplicationCallbackUri();
	}
}
