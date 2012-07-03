using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Security.Credentials
{
	[ExclusiveTo(typeof(PasswordVault)), Guid(1643981835u, 51412, 18625, 165, 79, 188, 90, 100, 32, 90, 242), Version(100794368u)]
	internal interface IPasswordVault
	{
		void Add([In] PasswordCredential credential);
		void Remove([In] PasswordCredential credential);
		PasswordCredential Retrieve([In] string resource, [In] string userName);
		IVectorView<PasswordCredential> FindAllByResource([In] string resource);
		IVectorView<PasswordCredential> FindAllByUserName([In] string userName);
		IVectorView<PasswordCredential> RetrieveAll();
	}
}
