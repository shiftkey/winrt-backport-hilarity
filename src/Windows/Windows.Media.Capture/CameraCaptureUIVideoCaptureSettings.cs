using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class CameraCaptureUIVideoCaptureSettings : ICameraCaptureUIVideoCaptureSettings
	{
		public extern bool AllowTrimming
		{
			get;
			set;
		}
		public extern CameraCaptureUIVideoFormat Format
		{
			get;
			set;
		}
		public extern float MaxDurationInSeconds
		{
			get;
			set;
		}
		public extern CameraCaptureUIMaxVideoResolution MaxResolution
		{
			get;
			set;
		}
	}
}
