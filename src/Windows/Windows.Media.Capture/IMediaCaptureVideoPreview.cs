using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
namespace Windows.Media.Capture
{
	[ExclusiveTo(typeof(MediaCapture)), Guid(661811315u, 21662, 17535, 162, 10, 79, 3, 196, 121, 216, 192), Version(100794368u), WebHostHidden]
	internal interface IMediaCaptureVideoPreview
	{
		IAsyncAction StartPreviewAsync();
		[Overload("StartPreviewToCustomSinkAsync")]
		IAsyncAction StartPreviewToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] IMediaExtension customMediaSink);
		[Overload("StartPreviewToCustomSinkIdAsync")]
		IAsyncAction StartPreviewToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] string customSinkActivationId, [In] IPropertySet customSinkSettings);
		IAsyncAction StopPreviewAsync();
	}
}
