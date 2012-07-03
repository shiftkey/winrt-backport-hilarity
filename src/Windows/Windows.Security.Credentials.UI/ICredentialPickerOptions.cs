using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Credentials.UI
{
	[ExclusiveTo(typeof(CredentialPickerOptions)), Guid(2522483532u, 38394, 18047, 153, 43, 11, 34, 229, 133, 155, 246), Version(100794368u)]
	internal interface ICredentialPickerOptions
	{
		bool AlwaysDisplayDialog
		{
			get;
			set;
		}
		AuthenticationProtocol AuthenticationProtocol
		{
			get;
			set;
		}
		bool CallerSavesCredential
		{
			get;
			set;
		}
		string Caption
		{
			get;
			set;
		}
		CredentialSaveOption CredentialSaveOption
		{
			get;
			set;
		}
		string CustomAuthenticationProtocol
		{
			get;
			set;
		}
		uint ErrorCode
		{
			get;
			set;
		}
		string Message
		{
			get;
			set;
		}
		IBuffer PreviousCredential
		{
			get;
			set;
		}
		string TargetName
		{
			get;
			set;
		}
	}
}
