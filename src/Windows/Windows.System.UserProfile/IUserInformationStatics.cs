using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.System.UserProfile
{
	[ExclusiveTo(typeof(UserInformation)), Guid(2012457232u, 18682, 18588, 147, 78, 42, 232, 91, 168, 247, 114), Version(100794368u)]
	internal interface IUserInformationStatics
	{
		event EventHandler<object> AccountPictureChanged;
		bool AccountPictureChangeEnabled
		{
			get;
		}
		bool NameAccessAllowed
		{
			get;
		}
		IStorageFile GetAccountPicture([In] AccountPictureKind kind);
		IAsyncOperation<SetAccountPictureResult> SetAccountPictureAsync([In] IStorageFile image);
		IAsyncOperation<SetAccountPictureResult> SetAccountPicturesAsync([In] IStorageFile smallImage, [In] IStorageFile largeImage, [In] IStorageFile video);
		IAsyncOperation<SetAccountPictureResult> SetAccountPictureFromStreamAsync([In] IRandomAccessStream image);
		IAsyncOperation<SetAccountPictureResult> SetAccountPicturesFromStreamsAsync([In] IRandomAccessStream smallImage, [In] IRandomAccessStream largeImage, [In] IRandomAccessStream video);
		IAsyncOperation<string> GetDisplayNameAsync();
		IAsyncOperation<string> GetFirstNameAsync();
		IAsyncOperation<string> GetLastNameAsync();
		IAsyncOperation<string> GetPrincipalNameAsync();
		IAsyncOperation<Uri> GetSessionInitiationProtocolUriAsync();
		IAsyncOperation<string> GetDomainNameAsync();
	}
}
