using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class MediaCaptureInitializationSettings : IMediaCaptureInitializationSettings
	{
		public extern string AudioDeviceId
		{
			get;
			set;
		}
		public extern PhotoCaptureSource PhotoCaptureSource
		{
			get;
			set;
		}
		public extern StreamingCaptureMode StreamingCaptureMode
		{
			get;
			set;
		}
		public extern string VideoDeviceId
		{
			get;
			set;
		}
		public extern MediaCaptureInitializationSettings();
	}
}
