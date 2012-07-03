using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class CameraCaptureUIPhotoCaptureSettings : ICameraCaptureUIPhotoCaptureSettings
	{
		public extern bool AllowCropping
		{
			get;
			set;
		}
		public extern Size CroppedAspectRatio
		{
			get;
			set;
		}
		public extern Size CroppedSizeInPixels
		{
			get;
			set;
		}
		public extern CameraCaptureUIPhotoFormat Format
		{
			get;
			set;
		}
		public extern CameraCaptureUIMaxPhotoResolution MaxResolution
		{
			get;
			set;
		}
	}
}
