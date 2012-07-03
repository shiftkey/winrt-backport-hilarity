using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Security.Credentials.UI
{
	[ExclusiveTo(typeof(CredentialPicker)), Guid(2855951475u, 51690, 18306, 153, 251, 230, 215, 233, 56, 225, 45), Version(100794368u)]
	internal interface ICredentialPickerStatics
	{
		[DefaultOverload, Overload("PickWithOptionsAsync")]
		IAsyncOperation<CredentialPickerResults> PickAsync([In] CredentialPickerOptions options);
		[DefaultOverload, Overload("PickWithMessageAsync")]
		IAsyncOperation<CredentialPickerResults> PickAsync([In] string targetName, [In] string message);
		[DefaultOverload, Overload("PickWithCaptionAsync")]
		IAsyncOperation<CredentialPickerResults> PickAsync([In] string targetName, [In] string message, [In] string caption);
	}
}
