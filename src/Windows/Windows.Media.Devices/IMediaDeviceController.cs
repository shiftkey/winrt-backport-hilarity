using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
namespace Windows.Media.Devices
{
	[Guid(4143510990u, 8346, 18683, 134, 252, 212, 69, 120, 243, 23, 230), Version(100794368u)]
	public interface IMediaDeviceController
	{
		IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties([In] MediaStreamType mediaStreamType);
		IMediaEncodingProperties GetMediaStreamProperties([In] MediaStreamType mediaStreamType);
		IAsyncAction SetMediaStreamPropertiesAsync([In] MediaStreamType mediaStreamType, [In] IMediaEncodingProperties mediaEncodingProperties);
	}
}
