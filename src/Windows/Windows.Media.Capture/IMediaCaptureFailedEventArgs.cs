using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[ExclusiveTo(typeof(MediaCaptureFailedEventArgs)), Guid(2164122612u, 21700, 17088, 141, 25, 206, 161, 168, 124, 161, 139), Version(100794368u)]
	internal interface IMediaCaptureFailedEventArgs
	{
		uint Code
		{
			get;
		}
		string Message
		{
			get;
		}
	}
}
