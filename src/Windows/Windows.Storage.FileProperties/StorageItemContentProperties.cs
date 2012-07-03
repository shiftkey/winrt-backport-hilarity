using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[Version(100794368u)]
	public sealed class StorageItemContentProperties : IStorageItemContentProperties, IStorageItemExtraProperties
	{
		public extern IAsyncOperation<MusicProperties> GetMusicPropertiesAsync();
		public extern IAsyncOperation<VideoProperties> GetVideoPropertiesAsync();
		public extern IAsyncOperation<ImageProperties> GetImagePropertiesAsync();
		public extern IAsyncOperation<DocumentProperties> GetDocumentPropertiesAsync();
		public extern IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync([In] IIterable<string> propertiesToRetrieve);
		[Overload("SavePropertiesAsync")]
		public extern IAsyncAction SavePropertiesAsync([HasVariant] [In] IIterable<IKeyValuePair<string, object>> propertiesToSave);
		[Overload("SavePropertiesAsyncOverloadDefault")]
		public extern IAsyncAction SavePropertiesAsync();
	}
}
