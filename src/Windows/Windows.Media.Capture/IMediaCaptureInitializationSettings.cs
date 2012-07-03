using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[ExclusiveTo(typeof(MediaCaptureInitializationSettings)), Guid(2541927024u, 60005, 18688, 147, 86, 140, 168, 135, 114, 104, 132), Version(100794368u)]
	internal interface IMediaCaptureInitializationSettings
	{
		string AudioDeviceId
		{
			get;
			set;
		}
		PhotoCaptureSource PhotoCaptureSource
		{
			get;
			set;
		}
		StreamingCaptureMode StreamingCaptureMode
		{
			get;
			set;
		}
		string VideoDeviceId
		{
			get;
			set;
		}
	}
}
