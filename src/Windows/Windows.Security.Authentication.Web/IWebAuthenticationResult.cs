using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.Web
{
	[ExclusiveTo(typeof(WebAuthenticationResult)), Guid(1677732683u, 60905, 18186, 165, 205, 3, 35, 250, 246, 226, 98), Version(100794368u)]
	internal interface IWebAuthenticationResult
	{
		string ResponseData
		{
			get;
		}
		uint ResponseErrorDetail
		{
			get;
		}
		WebAuthenticationStatus ResponseStatus
		{
			get;
		}
	}
}
