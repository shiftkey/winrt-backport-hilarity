using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Credentials.UI
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class CredentialPickerOptions : ICredentialPickerOptions
	{
		public extern bool AlwaysDisplayDialog
		{
			get;
			set;
		}
		public extern AuthenticationProtocol AuthenticationProtocol
		{
			get;
			set;
		}
		public extern bool CallerSavesCredential
		{
			get;
			set;
		}
		public extern string Caption
		{
			get;
			set;
		}
		public extern CredentialSaveOption CredentialSaveOption
		{
			get;
			set;
		}
		public extern string CustomAuthenticationProtocol
		{
			get;
			set;
		}
		public extern uint ErrorCode
		{
			get;
			set;
		}
		public extern string Message
		{
			get;
			set;
		}
		public extern IBuffer PreviousCredential
		{
			get;
			set;
		}
		public extern string TargetName
		{
			get;
			set;
		}
		public extern CredentialPickerOptions();
	}
}
