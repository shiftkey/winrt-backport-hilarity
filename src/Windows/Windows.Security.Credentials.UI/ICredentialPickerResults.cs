using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Credentials.UI
{
	[ExclusiveTo(typeof(CredentialPickerResults)), Guid(424212890u, 52272, 16652, 156, 56, 204, 8, 132, 197, 179, 215), Version(100794368u)]
	internal interface ICredentialPickerResults
	{
		IBuffer Credential
		{
			get;
		}
		string CredentialDomainName
		{
			get;
		}
		string CredentialPassword
		{
			get;
		}
		CredentialSaveOption CredentialSaveOption
		{
			get;
		}
		bool CredentialSaved
		{
			get;
		}
		string CredentialUserName
		{
			get;
		}
		uint ErrorCode
		{
			get;
		}
	}
}
