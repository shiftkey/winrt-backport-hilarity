using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[ExclusiveTo(typeof(CameraCaptureUIPhotoCaptureSettings)), Guid(3119890071u, 13426, 18088, 138, 158, 4, 206, 66, 204, 201, 125), Version(100794368u)]
	internal interface ICameraCaptureUIPhotoCaptureSettings
	{
		bool AllowCropping
		{
			get;
			set;
		}
		Size CroppedAspectRatio
		{
			get;
			set;
		}
		Size CroppedSizeInPixels
		{
			get;
			set;
		}
		CameraCaptureUIPhotoFormat Format
		{
			get;
			set;
		}
		CameraCaptureUIMaxPhotoResolution MaxResolution
		{
			get;
			set;
		}
	}
}
