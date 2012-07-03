using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[ExclusiveTo(typeof(MediaEncodingProfile)), Guid(3889952168u, 7609, 18307, 135, 107, 61, 254, 18, 172, 253, 179), Version(100794368u)]
	internal interface IMediaEncodingProfile
	{
		AudioEncodingProperties Audio
		{
			get;
			set;
		}
		ContainerEncodingProperties Container
		{
			get;
			set;
		}
		VideoEncodingProperties Video
		{
			get;
			set;
		}
	}
}
