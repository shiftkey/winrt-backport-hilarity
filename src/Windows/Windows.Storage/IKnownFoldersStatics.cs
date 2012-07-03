using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(KnownFolders)), Guid(1512731936u, 18434, 17709, 154, 217, 67, 81, 173, 167, 236, 53), Version(100794368u)]
	internal interface IKnownFoldersStatics
	{
		StorageFolder DocumentsLibrary
		{
			get;
		}
		StorageFolder HomeGroup
		{
			get;
		}
		StorageFolder MediaServerDevices
		{
			get;
		}
		StorageFolder MusicLibrary
		{
			get;
		}
		StorageFolder PicturesLibrary
		{
			get;
		}
		StorageFolder RemovableDevices
		{
			get;
		}
		StorageFolder VideosLibrary
		{
			get;
		}
	}
}
