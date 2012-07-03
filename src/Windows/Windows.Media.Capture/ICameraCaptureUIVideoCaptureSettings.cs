using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[ExclusiveTo(typeof(CameraCaptureUIVideoCaptureSettings)), Guid(1693003039u, 41613, 16986, 184, 79, 229, 104, 51, 95, 242, 78), Version(100794368u)]
	internal interface ICameraCaptureUIVideoCaptureSettings
	{
		bool AllowTrimming
		{
			get;
			set;
		}
		CameraCaptureUIVideoFormat Format
		{
			get;
			set;
		}
		float MaxDurationInSeconds
		{
			get;
			set;
		}
		CameraCaptureUIMaxVideoResolution MaxResolution
		{
			get;
			set;
		}
	}
}
