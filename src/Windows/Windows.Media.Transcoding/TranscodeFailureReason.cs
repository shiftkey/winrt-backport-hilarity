using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Transcoding
{
	[Version(100794368u)]
	public enum TranscodeFailureReason
	{
		None,
		Unknown,
		InvalidProfile,
		CodecNotFound
	}
}
