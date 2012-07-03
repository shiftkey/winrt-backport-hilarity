using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class MediaCaptureSettings : IMediaCaptureSettings
	{
		public extern string AudioDeviceId
		{
			get;
		}
		public extern PhotoCaptureSource PhotoCaptureSource
		{
			get;
		}
		public extern StreamingCaptureMode StreamingCaptureMode
		{
			get;
		}
		public extern VideoDeviceCharacteristic VideoDeviceCharacteristic
		{
			get;
		}
		public extern string VideoDeviceId
		{
			get;
		}
	}
}
