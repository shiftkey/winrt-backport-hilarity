using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.System.UserProfile
{
	[ExclusiveTo(typeof(LockScreen)), Guid(1055511469u, 46599, 16558, 180, 38, 118, 49, 217, 130, 18, 105), Version(100794368u)]
	internal interface ILockScreenStatics
	{
		Uri OriginalImageFile
		{
			get;
		}
		IRandomAccessStream GetImageStream();
		IAsyncAction SetImageFileAsync([In] IStorageFile value);
		IAsyncAction SetImageStreamAsync([In] IRandomAccessStream value);
	}
}
