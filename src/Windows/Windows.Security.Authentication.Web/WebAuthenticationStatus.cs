using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.Web
{
	[Version(100794368u)]
	public enum WebAuthenticationStatus
	{
		Success,
		UserCancel,
		ErrorHttp
	}
}
