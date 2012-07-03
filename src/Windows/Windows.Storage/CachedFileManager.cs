using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;
namespace Windows.Storage
{
	[Static(typeof(ICachedFileManagerStatics), 100794368u), Version(100794368u)]
	public static class CachedFileManager
	{
		public static extern void DeferUpdates([In] IStorageFile file);
		public static extern IAsyncOperation<FileUpdateStatus> CompleteUpdatesAsync([In] IStorageFile file);
	}
}
