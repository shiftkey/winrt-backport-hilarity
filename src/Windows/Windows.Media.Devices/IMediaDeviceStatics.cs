using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[ExclusiveTo(typeof(MediaDevice)), Guid(2855115328u, 37023, 19386, 191, 139, 12, 13, 41, 111, 20, 240), Version(100794368u)]
	internal interface IMediaDeviceStatics
	{
		event TypedEventHandler<object, DefaultAudioCaptureDeviceChangedEventArgs> DefaultAudioCaptureDeviceChanged;
		event TypedEventHandler<object, DefaultAudioRenderDeviceChangedEventArgs> DefaultAudioRenderDeviceChanged;
		string GetAudioCaptureSelector();
		string GetAudioRenderSelector();
		string GetVideoCaptureSelector();
		string GetDefaultAudioCaptureId([In] AudioDeviceRole role);
		string GetDefaultAudioRenderId([In] AudioDeviceRole role);
	}
}
