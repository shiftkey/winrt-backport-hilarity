using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.Web
{
	[Version(100794368u)]
	public sealed class WebAuthenticationResult : IWebAuthenticationResult
	{
		public extern string ResponseData
		{
			get;
		}
		public extern uint ResponseErrorDetail
		{
			get;
		}
		public extern WebAuthenticationStatus ResponseStatus
		{
			get;
		}
	}
}
