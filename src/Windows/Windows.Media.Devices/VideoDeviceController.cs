using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
namespace Windows.Media.Devices
{
	[MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class VideoDeviceController : IVideoDeviceController, IMediaDeviceController, IAdvancedVideoCaptureDeviceController
	{
		public extern MediaDeviceControl BacklightCompensation
		{
			get;
		}
		public extern MediaDeviceControl Brightness
		{
			get;
		}
		public extern MediaDeviceControl Contrast
		{
			get;
		}
		public extern MediaDeviceControl Exposure
		{
			get;
		}
		public extern MediaDeviceControl Focus
		{
			get;
		}
		public extern MediaDeviceControl Hue
		{
			get;
		}
		public extern MediaDeviceControl Pan
		{
			get;
		}
		public extern MediaDeviceControl Roll
		{
			get;
		}
		public extern MediaDeviceControl Tilt
		{
			get;
		}
		public extern MediaDeviceControl WhiteBalance
		{
			get;
		}
		public extern MediaDeviceControl Zoom
		{
			get;
		}
		public extern bool TrySetPowerlineFrequency([In] PowerlineFrequency value);
		public extern bool TryGetPowerlineFrequency(out PowerlineFrequency value);
		public extern IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties([In] MediaStreamType mediaStreamType);
		public extern IMediaEncodingProperties GetMediaStreamProperties([In] MediaStreamType mediaStreamType);
		public extern IAsyncAction SetMediaStreamPropertiesAsync([In] MediaStreamType mediaStreamType, [In] IMediaEncodingProperties mediaEncodingProperties);
		public extern void SetDeviceProperty([In] string propertyId, [Variant] [In] object propertyValue);
		[return: Variant]
		public extern object GetDeviceProperty([In] string propertyId);
	}
}
