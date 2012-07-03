using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(CachedFileManager)), Guid(2415665738u, 59266, 18781, 182, 20, 101, 76, 79, 11, 35, 112), Version(100794368u)]
	internal interface ICachedFileManagerStatics
	{
		void DeferUpdates([In] IStorageFile file);
		IAsyncOperation<FileUpdateStatus> CompleteUpdatesAsync([In] IStorageFile file);
	}
}
