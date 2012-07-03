using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[ExclusiveTo(typeof(VideoEncodingProperties)), Guid(1995336858u, 14274, 20266, 136, 10, 18, 130, 187, 180, 55, 61), Version(100794368u)]
	internal interface IVideoEncodingProperties : IMediaEncodingProperties
	{
		uint Bitrate
		{
			get;
			set;
		}
		MediaRatio FrameRate
		{
			get;
		}
		uint Height
		{
			get;
			set;
		}
		MediaRatio PixelAspectRatio
		{
			get;
		}
		uint Width
		{
			get;
			set;
		}
	}
}
