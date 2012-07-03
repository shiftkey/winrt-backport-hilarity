using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.System
{
	[MarshalingBehavior(MarshalingType.Standard), Static(typeof(ILauncherStatics), 100794368u), Version(100794368u)]
	public static class Launcher
	{
		[Overload("LaunchFileAsync")]
		public static extern IAsyncOperation<bool> LaunchFileAsync([In] IStorageFile file);
		[Overload("LaunchFileWithOptionsAsync")]
		public static extern IAsyncOperation<bool> LaunchFileAsync([In] IStorageFile file, [In] LauncherOptions options);
		[Overload("LaunchUriAsync")]
		public static extern IAsyncOperation<bool> LaunchUriAsync([In] Uri uri);
		[Overload("LaunchUriWithOptionsAsync")]
		public static extern IAsyncOperation<bool> LaunchUriAsync([In] Uri uri, [In] LauncherOptions options);
	}
}
