using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Security.Credentials
{
	[ExclusiveTo(typeof(PasswordCredential)), Guid(1424954273u, 48934, 18357, 151, 221, 222, 119, 155, 124, 173, 88), Version(100794368u)]
	internal interface ICredentialFactory
	{
		PasswordCredential CreatePasswordCredential([In] string resource, [In] string userName, [In] string password);
	}
}
