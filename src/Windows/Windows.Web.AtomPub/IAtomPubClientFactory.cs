using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
namespace Windows.Web.AtomPub
{
	[ExclusiveTo(typeof(AtomPubClient)), Guid(1238716434u, 22475, 19422, 171, 159, 38, 16, 177, 114, 119, 123), Version(100794368u)]
	internal interface IAtomPubClientFactory
	{
		AtomPubClient CreateAtomPubClientWithCredentials([In] PasswordCredential serverCredential);
	}
}
