using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(CachedFileManager))]
	internal interface ICachedFileManagerStatics
	{
		void DeferUpdates([In] IStorageFile file);
		IAsyncOperation<FileUpdateStatus> CompleteUpdatesAsync([In] IStorageFile file);
	}
}
