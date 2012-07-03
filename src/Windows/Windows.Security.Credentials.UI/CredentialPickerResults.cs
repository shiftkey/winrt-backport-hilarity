using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Credentials.UI
{
	[Version(100794368u)]
	public sealed class CredentialPickerResults : ICredentialPickerResults
	{
		public extern IBuffer Credential
		{
			get;
		}
		public extern string CredentialDomainName
		{
			get;
		}
		public extern string CredentialPassword
		{
			get;
		}
		public extern CredentialSaveOption CredentialSaveOption
		{
			get;
		}
		public extern bool CredentialSaved
		{
			get;
		}
		public extern string CredentialUserName
		{
			get;
		}
		public extern uint ErrorCode
		{
			get;
		}
	}
}
