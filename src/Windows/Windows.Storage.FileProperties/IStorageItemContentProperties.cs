using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[ExclusiveTo(typeof(StorageItemContentProperties)), Guid(86592429u, 48184, 18623, 133, 215, 119, 14, 14, 42, 224, 186), Version(100794368u)]
	internal interface IStorageItemContentProperties : IStorageItemExtraProperties
	{
		IAsyncOperation<MusicProperties> GetMusicPropertiesAsync();
		IAsyncOperation<VideoProperties> GetVideoPropertiesAsync();
		IAsyncOperation<ImageProperties> GetImagePropertiesAsync();
		IAsyncOperation<DocumentProperties> GetDocumentPropertiesAsync();
	}
}
