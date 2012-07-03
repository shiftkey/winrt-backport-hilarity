using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Media.Capture
{
	[ExclusiveTo(typeof(CameraCaptureUI)), Guid(1213756736u, 28563, 19380, 184, 243, 232, 158, 72, 148, 140, 145), Version(100794368u)]
	internal interface ICameraCaptureUI
	{
		CameraCaptureUIPhotoCaptureSettings PhotoSettings
		{
			get;
		}
		CameraCaptureUIVideoCaptureSettings VideoSettings
		{
			get;
		}
		IAsyncOperation<StorageFile> CaptureFileAsync([In] CameraCaptureUIMode mode);
	}
}
