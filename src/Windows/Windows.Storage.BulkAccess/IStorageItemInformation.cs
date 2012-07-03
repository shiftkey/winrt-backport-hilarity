using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
namespace Windows.Storage.BulkAccess
{
	[Guid(2275789707u, 35186, 20288, 141, 224, 216, 111, 177, 121, 216, 250), Version(100794368u)]
	public interface IStorageItemInformation
	{
		event TypedEventHandler<IStorageItemInformation, object> PropertiesUpdated;
		event TypedEventHandler<IStorageItemInformation, object> ThumbnailUpdated;
		BasicProperties BasicProperties
		{
			get;
		}
		DocumentProperties DocumentProperties
		{
			get;
		}
		ImageProperties ImageProperties
		{
			get;
		}
		MusicProperties MusicProperties
		{
			get;
		}
		StorageItemThumbnail Thumbnail
		{
			get;
		}
		VideoProperties VideoProperties
		{
			get;
		}
	}
}
