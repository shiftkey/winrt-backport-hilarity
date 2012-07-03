using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Media.Playlists
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), Static(typeof(IPlaylistStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class Playlist : IPlaylist
	{
		public extern IVector<StorageFile> Files
		{
			get;
		}
		public extern Playlist();
		public extern IAsyncAction SaveAsync();
		[Overload("SaveAsAsync")]
		public extern IAsyncOperation<StorageFile> SaveAsAsync([In] IStorageFolder saveLocation, [In] string desiredName, [In] NameCollisionOption option);
		[Overload("SaveAsWithFormatAsync")]
		public extern IAsyncOperation<StorageFile> SaveAsAsync([In] IStorageFolder saveLocation, [In] string desiredName, [In] NameCollisionOption option, [In] PlaylistFormat playlistFormat);
		public static extern IAsyncOperation<Playlist> LoadAsync([In] IStorageFile file);
	}
}
