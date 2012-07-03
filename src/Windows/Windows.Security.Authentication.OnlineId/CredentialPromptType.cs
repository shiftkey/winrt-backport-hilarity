using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Authentication.OnlineId
{
	[Version(100794368u)]
	public enum CredentialPromptType
	{
		PromptIfNeeded,
		RetypeCredentials,
		DoNotPrompt
	}
}
