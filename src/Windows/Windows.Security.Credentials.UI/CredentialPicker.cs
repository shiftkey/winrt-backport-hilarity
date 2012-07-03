using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Security.Credentials.UI
{
	[Static(typeof(ICredentialPickerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class CredentialPicker
	{
		[DefaultOverload, Overload("PickWithOptionsAsync")]
		public static extern IAsyncOperation<CredentialPickerResults> PickAsync([In] CredentialPickerOptions options);
		[DefaultOverload, Overload("PickWithMessageAsync")]
		public static extern IAsyncOperation<CredentialPickerResults> PickAsync([In] string targetName, [In] string message);
		[DefaultOverload, Overload("PickWithCaptionAsync")]
		public static extern IAsyncOperation<CredentialPickerResults> PickAsync([In] string targetName, [In] string message, [In] string caption);
	}
}
