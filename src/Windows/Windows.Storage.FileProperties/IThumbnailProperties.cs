using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[ExclusiveTo(typeof(StorageItemThumbnail)), Guid(1765659695u, 56295, 18869, 179, 179, 40, 147, 172, 93, 52, 35), Version(100794368u)]
	internal interface IThumbnailProperties
	{
		uint OriginalHeight
		{
			get;
		}
		uint OriginalWidth
		{
			get;
		}
		bool ReturnedSmallerCachedSize
		{
			get;
		}
		ThumbnailType Type
		{
			get;
		}
	}
}
