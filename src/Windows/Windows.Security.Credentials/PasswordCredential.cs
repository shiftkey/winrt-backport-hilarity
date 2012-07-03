using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Security.Credentials
{
	[Activatable(100794368u), Activatable(typeof(ICredentialFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PasswordCredential : IPasswordCredential
	{
		public extern string Password
		{
			get;
			set;
		}
		public extern IPropertySet Properties
		{
			get;
		}
		public extern string Resource
		{
			get;
			set;
		}
		public extern string UserName
		{
			get;
			set;
		}
		public extern PasswordCredential([In] string resource, [In] string userName, [In] string password);
		public extern PasswordCredential();
		public extern void RetrievePassword();
	}
}
