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
	[ExclusiveTo(typeof(MediaCapture)), Guid(3323657140u, 64272, 18996, 172, 24, 202, 128, 217, 200, 231, 238), Version(100794368u)]
	internal interface IMediaCapture
	{
		event MediaCaptureFailedEventHandler Failed;
		event RecordLimitationExceededEventHandler RecordLimitationExceeded;
		AudioDeviceController AudioDeviceController
		{
			get;
		}
		MediaCaptureSettings MediaCaptureSettings
		{
			get;
		}
		VideoDeviceController VideoDeviceController
		{
			get;
		}
		[Overload("InitializeAsync")]
		IAsyncAction InitializeAsync();
		[Overload("InitializeWithSettingsAsync")]
		IAsyncAction InitializeAsync([In] MediaCaptureInitializationSettings mediaCaptureInitializationSettings);
		IAsyncAction StartRecordToStorageFileAsync([In] MediaEncodingProfile encodingProfile, [In] IStorageFile file);
		IAsyncAction StartRecordToStreamAsync([In] MediaEncodingProfile encodingProfile, [In] IRandomAccessStream stream);
		[Overload("StartRecordToCustomSinkAsync")]
		IAsyncAction StartRecordToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] IMediaExtension customMediaSink);
		[Overload("StartRecordToCustomSinkIdAsync")]
		IAsyncAction StartRecordToCustomSinkAsync([In] MediaEncodingProfile encodingProfile, [In] string customSinkActivationId, [In] IPropertySet customSinkSettings);
		IAsyncAction StopRecordAsync();
		IAsyncAction CapturePhotoToStorageFileAsync([In] ImageEncodingProperties type, [In] IStorageFile file);
		IAsyncAction CapturePhotoToStreamAsync([In] ImageEncodingProperties type, [In] IRandomAccessStream stream);
		IAsyncAction AddEffectAsync([In] MediaStreamType mediaStreamType, [In] string effectActivationID, [In] IPropertySet effectSettings);
		IAsyncAction ClearEffectsAsync([In] MediaStreamType mediaStreamType);
		void SetEncoderProperty([In] MediaStreamType mediaStreamType, [In] Guid propertyId, [In] object propertyValue);
		object GetEncoderProperty([In] MediaStreamType mediaStreamType, [In] Guid propertyId);
		void SetPreviewMirroring([In] bool value);
		bool GetPreviewMirroring();
		void SetPreviewRotation([In] VideoRotation value);
		VideoRotation GetPreviewRotation();
		void SetRecordRotation([In] VideoRotation value);
		VideoRotation GetRecordRotation();
	}
}
