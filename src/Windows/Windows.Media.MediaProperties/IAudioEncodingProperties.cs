using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.MediaProperties
{
	[ExclusiveTo(typeof(AudioEncodingProperties)), Guid(1656519190u, 92, 19259, 138, 11, 10, 9, 14, 150, 135, 243), Version(100794368u)]
	internal interface IAudioEncodingProperties : IMediaEncodingProperties
	{
		uint Bitrate
		{
			get;
			set;
		}
		uint BitsPerSample
		{
			get;
			set;
		}
		uint ChannelCount
		{
			get;
			set;
		}
		uint SampleRate
		{
			get;
			set;
		}
	}
}
