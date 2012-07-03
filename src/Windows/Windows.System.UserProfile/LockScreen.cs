using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.System.UserProfile
{
	[DualApiPartition(version = 100794368u), Static(typeof(ILockScreenStatics), 100794368u), Version(100794368u)]
	public static class LockScreen
	{
		public static extern Uri OriginalImageFile
		{
			get;
		}
		public static extern IRandomAccessStream GetImageStream();
		public static extern IAsyncAction SetImageFileAsync([In] IStorageFile value);
		public static extern IAsyncAction SetImageStreamAsync([In] IRandomAccessStream value);
	}
}
