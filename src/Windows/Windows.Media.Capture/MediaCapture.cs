using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.Media.Capture
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class MediaCapture : IMediaCapture, IMediaCaptureVideoPreview
	{
		public extern event MediaCaptureFailedEventHandler Failed
		{
			add;
			remove;
		}
		public extern event RecordLimitationExceededEventHandler RecordLimitationExceeded
		{
			add;
			remove;
		}
		public extern AudioDeviceController AudioDeviceController
		{
			get;
		}
		public extern MediaCaptureSettings MediaCaptureSettings
		{
			get;
		}
		public extern VideoDeviceController VideoDeviceController
		{
			get;
		}
		public extern MediaCapture();
		[Overload("InitializeAsync")]
		public extern IAsyncAction InitializeAsync();
		[Overload("InitializeWithSettingsAsync")]
		public extern IAsyncAction InitializeAsync([In] MediaCaptureInitializationSettings mediaCaptureInitializationSettings);
		public extern IAsyncAction StartRecordToStorageFileAsync([In] MediaEncodingProfile encodingProfile, [In] IStorageFile file);
		public extern IAsyncAction StartRecordToStreamAsync([In] MediaEncodingProfile encodingProfile, [In] IRandomAccessStream stream);
		[Overload("StartRecordToCustomSinkAsync")]
		public extern IAsyncAction StartRecordToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] IMediaExtension customMediaSink);
		[Overload("StartRecordToCustomSinkIdAsync")]
		public extern IAsyncAction StartRecordToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] string customSinkActivationId, [In] IPropertySet customSinkSettings);
		public extern IAsyncAction StopRecordAsync();
		public extern IAsyncAction CapturePhotoToStorageFileAsync([In] ImageEncodingProperties type, [In] IStorageFile file);
		public extern IAsyncAction CapturePhotoToStreamAsync([In] ImageEncodingProperties type, [In] IRandomAccessStream stream);
		public extern IAsyncAction AddEffectAsync([In] MediaStreamType mediaStreamType, [In] string effectActivationID, [In] IPropertySet effectSettings);
		public extern IAsyncAction ClearEffectsAsync([In] MediaStreamType mediaStreamType);
		public extern void SetEncoderProperty([In] MediaStreamType mediaStreamType, [In] Guid propertyId, [In] object propertyValue);
		public extern object GetEncoderProperty([In] MediaStreamType mediaStreamType, [In] Guid propertyId);
		public extern void SetPreviewMirroring([In] bool value);
		public extern bool GetPreviewMirroring();
		public extern void SetPreviewRotation([In] VideoRotation value);
		public extern VideoRotation GetPreviewRotation();
		public extern void SetRecordRotation([In] VideoRotation value);
		public extern VideoRotation GetRecordRotation();
		public extern IAsyncAction StartPreviewAsync();
		[Overload("StartPreviewToCustomSinkAsync")]
		public extern IAsyncAction StartPreviewToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] IMediaExtension customMediaSink);
		[Overload("StartPreviewToCustomSinkIdAsync")]
		public extern IAsyncAction StartPreviewToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] string customSinkActivationId, [In] IPropertySet customSinkSettings);
		public extern IAsyncAction StopPreviewAsync();
	}
}
