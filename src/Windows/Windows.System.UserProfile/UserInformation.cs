using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.System.UserProfile
{
	[DualApiPartition(version = 100794368u), Static(typeof(IUserInformationStatics), 100794368u), Version(100794368u)]
	public static class UserInformation
	{
		public static extern event EventHandler<object> AccountPictureChanged
		{
			add;
			remove;
		}
		public static extern bool AccountPictureChangeEnabled
		{
			get;
		}
		public static extern bool NameAccessAllowed
		{
			get;
		}
		public static extern IStorageFile GetAccountPicture([In] AccountPictureKind kind);
		public static extern IAsyncOperation<SetAccountPictureResult> SetAccountPictureAsync([In] IStorageFile image);
		public static extern IAsyncOperation<SetAccountPictureResult> SetAccountPicturesAsync([In] IStorageFile smallImage, [In] IStorageFile largeImage, [In] IStorageFile video);
		public static extern IAsyncOperation<SetAccountPictureResult> SetAccountPictureFromStreamAsync([In] IRandomAccessStream image);
		public static extern IAsyncOperation<SetAccountPictureResult> SetAccountPicturesFromStreamsAsync([In] IRandomAccessStream smallImage, [In] IRandomAccessStream largeImage, [In] IRandomAccessStream video);
		public static extern IAsyncOperation<string> GetDisplayNameAsync();
		public static extern IAsyncOperation<string> GetFirstNameAsync();
		public static extern IAsyncOperation<string> GetLastNameAsync();
		public static extern IAsyncOperation<string> GetPrincipalNameAsync();
		public static extern IAsyncOperation<Uri> GetSessionInitiationProtocolUriAsync();
		public static extern IAsyncOperation<string> GetDomainNameAsync();
	}
}
