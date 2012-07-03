using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.Media.MediaProperties
{
	[ExclusiveTo(typeof(MediaEncodingProfile)), Guid(427767084u, 11998, 19013, 168, 150, 129, 122, 72, 84, 248, 254), Version(100794368u)]
	internal interface IMediaEncodingProfileStatics
	{
		MediaEncodingProfile CreateM4a([In] AudioEncodingQuality quality);
		MediaEncodingProfile CreateMp3([In] AudioEncodingQuality quality);
		MediaEncodingProfile CreateWma([In] AudioEncodingQuality quality);
		MediaEncodingProfile CreateMp4([In] VideoEncodingQuality quality);
		MediaEncodingProfile CreateWmv([In] VideoEncodingQuality quality);
		IAsyncOperation<MediaEncodingProfile> CreateFromFileAsync([In] IStorageFile file);
		IAsyncOperation<MediaEncodingProfile> CreateFromStreamAsync([In] IRandomAccessStream stream);
	}
}
