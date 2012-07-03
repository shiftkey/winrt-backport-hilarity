using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Media.Capture
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.None), Threading(ThreadingModel.STA), Version(100794368u)]
	public sealed class CameraCaptureUI : ICameraCaptureUI
	{
		public extern CameraCaptureUIPhotoCaptureSettings PhotoSettings
		{
			get;
		}
		public extern CameraCaptureUIVideoCaptureSettings VideoSettings
		{
			get;
		}
		public extern CameraCaptureUI();
		public extern IAsyncOperation<StorageFile> CaptureFileAsync([In] CameraCaptureUIMode mode);
	}
}
