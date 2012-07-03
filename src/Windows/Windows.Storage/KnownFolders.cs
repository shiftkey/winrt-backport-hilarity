using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IKnownFoldersStatics), 100794368u), Version(100794368u)]
	public static class KnownFolders
	{
		public static extern StorageFolder DocumentsLibrary
		{
			get;
		}
		public static extern StorageFolder HomeGroup
		{
			get;
		}
		public static extern StorageFolder MediaServerDevices
		{
			get;
		}
		public static extern StorageFolder MusicLibrary
		{
			get;
		}
		public static extern StorageFolder PicturesLibrary
		{
			get;
		}
		public static extern StorageFolder RemovableDevices
		{
			get;
		}
		public static extern StorageFolder VideosLibrary
		{
			get;
		}
	}
}
