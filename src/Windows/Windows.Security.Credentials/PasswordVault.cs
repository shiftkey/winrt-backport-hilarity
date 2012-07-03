using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Security.Credentials
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PasswordVault : IPasswordVault
	{
		public extern PasswordVault();
		public extern void Add([In] PasswordCredential credential);
		public extern void Remove([In] PasswordCredential credential);
		public extern PasswordCredential Retrieve([In] string resource, [In] string userName);
		public extern IVectorView<PasswordCredential> FindAllByResource([In] string resource);
		public extern IVectorView<PasswordCredential> FindAllByUserName([In] string userName);
		public extern IVectorView<PasswordCredential> RetrieveAll();
	}
}
