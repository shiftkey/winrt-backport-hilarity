using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.Media.MediaProperties
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IMediaEncodingProfileStatics), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class MediaEncodingProfile : IMediaEncodingProfile
	{
		public extern AudioEncodingProperties Audio
		{
			get;
			set;
		}
		public extern ContainerEncodingProperties Container
		{
			get;
			set;
		}
		public extern VideoEncodingProperties Video
		{
			get;
			set;
		}
		public extern MediaEncodingProfile();
		public static extern MediaEncodingProfile CreateM4a([In] AudioEncodingQuality quality);
		public static extern MediaEncodingProfile CreateMp3([In] AudioEncodingQuality quality);
		public static extern MediaEncodingProfile CreateWma([In] AudioEncodingQuality quality);
		public static extern MediaEncodingProfile CreateMp4([In] VideoEncodingQuality quality);
		public static extern MediaEncodingProfile CreateWmv([In] VideoEncodingQuality quality);
		public static extern IAsyncOperation<MediaEncodingProfile> CreateFromFileAsync([In] IStorageFile file);
		public static extern IAsyncOperation<MediaEncodingProfile> CreateFromStreamAsync([In] IRandomAccessStream stream);
	}
}
