using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Media.Playlists
{
	[ExclusiveTo(typeof(Playlist)), Guid(3317903821u, 33273, 20467, 149, 185, 112, 182, 255, 4, 107, 104), Version(100794368u)]
	internal interface IPlaylistStatics
	{
		IAsyncOperation<Playlist> LoadAsync([In] IStorageFile file);
	}
}
