using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Media.Playlists
{
	[ExclusiveTo(typeof(Playlist)), Guid(2151102197u, 53060, 19863, 131, 179, 122, 8, 158, 154, 182, 99), Version(100794368u)]
	internal interface IPlaylist
	{
		IVector<StorageFile> Files
		{
			get;
		}
		IAsyncAction SaveAsync();
		[Overload("SaveAsAsync")]
		IAsyncOperation<StorageFile> SaveAsAsync([In] IStorageFolder saveLocation, [In] string desiredName, [In] NameCollisionOption option);
		[Overload("SaveAsWithFormatAsync")]
		IAsyncOperation<StorageFile> SaveAsAsync([In] IStorageFolder saveLocation, [In] string desiredName, [In] NameCollisionOption option, [In] PlaylistFormat playlistFormat);
	}
}
