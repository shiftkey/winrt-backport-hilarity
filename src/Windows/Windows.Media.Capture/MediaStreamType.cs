using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[Version(100794368u)]
	public enum MediaStreamType
	{
		VideoPreview,
		VideoRecord,
		Audio,
		Photo
	}
}
