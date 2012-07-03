using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IMediaDeviceStatics), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public static class MediaDevice
	{
		public static extern event TypedEventHandler<object, DefaultAudioCaptureDeviceChangedEventArgs> DefaultAudioCaptureDeviceChanged
		{
			add;
			remove;
		}
		public static extern event TypedEventHandler<object, DefaultAudioRenderDeviceChangedEventArgs> DefaultAudioRenderDeviceChanged
		{
			add;
			remove;
		}
		public static extern string GetAudioCaptureSelector();
		public static extern string GetAudioRenderSelector();
		public static extern string GetVideoCaptureSelector();
		public static extern string GetDefaultAudioCaptureId([In] AudioDeviceRole role);
		public static extern string GetDefaultAudioRenderId([In] AudioDeviceRole role);
	}
}
