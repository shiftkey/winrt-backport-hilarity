using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.Web
{
	[Flags, Version(100794368u)]
	public enum WebAuthenticationOptions : uint
	{
		None = 0u,
		SilentMode = 1u,
		UseTitle = 2u,
		UseHttpPost = 4u,
		UseCorporateNetwork = 8u
	}
}
