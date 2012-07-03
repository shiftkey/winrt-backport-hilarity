using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.System
{
	[ExclusiveTo(typeof(Launcher)), Guid(661737923u, 40510, 17142, 145, 164, 93, 253, 235, 35, 36, 81), Version(100794368u)]
	internal interface ILauncherStatics
	{
		[Overload("LaunchFileAsync")]
		IAsyncOperation<bool> LaunchFileAsync([In] IStorageFile file);
		[Overload("LaunchFileWithOptionsAsync")]
		IAsyncOperation<bool> LaunchFileAsync([In] IStorageFile file, [In] LauncherOptions options);
		[Overload("LaunchUriAsync")]
		IAsyncOperation<bool> LaunchUriAsync([In] Uri uri);
		[Overload("LaunchUriWithOptionsAsync")]
		IAsyncOperation<bool> LaunchUriAsync([In] Uri uri, [In] LauncherOptions options);
	}
}
