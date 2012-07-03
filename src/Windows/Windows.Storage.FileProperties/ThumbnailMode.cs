using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[Version(100794368u)]
	public enum ThumbnailMode
	{
		PicturesView,
		VideosView,
		MusicView,
		DocumentsView,
		ListView,
		SingleItem
	}
}
