using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[ExclusiveTo(typeof(MediaCaptureSettings)), Guid(495168254u, 27973, 17527, 141, 196, 172, 91, 192, 28, 64, 145), Version(100794368u)]
	internal interface IMediaCaptureSettings
	{
		string AudioDeviceId
		{
			get;
		}
		PhotoCaptureSource PhotoCaptureSource
		{
			get;
		}
		StreamingCaptureMode StreamingCaptureMode
		{
			get;
		}
		VideoDeviceCharacteristic VideoDeviceCharacteristic
		{
			get;
		}
		string VideoDeviceId
		{
			get;
		}
	}
}
