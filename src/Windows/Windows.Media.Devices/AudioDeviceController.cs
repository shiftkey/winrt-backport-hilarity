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
	public sealed class AudioDeviceController : IAudioDeviceController, IMediaDeviceController
	{
		public extern bool Muted
		{
			get;
			set;
		}
		public extern float VolumePercent
		{
			get;
			set;
		}
		public extern IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties([In] MediaStreamType mediaStreamType);
		public extern IMediaEncodingProperties GetMediaStreamProperties([In] MediaStreamType mediaStreamType);
		public extern IAsyncAction SetMediaStreamPropertiesAsync([In] MediaStreamType mediaStreamType, [In] IMediaEncodingProperties mediaEncodingProperties);
	}
}
