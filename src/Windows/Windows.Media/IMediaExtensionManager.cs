using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Media
{
	[ExclusiveTo(typeof(MediaExtensionManager)), Guid(1243998965u, 9261, 19963, 151, 244, 105, 183, 196, 37, 118, 255), Version(100794368u)]
	internal interface IMediaExtensionManager
	{
		[Overload("RegisterSchemeHandler")]
		void RegisterSchemeHandler([In] string activatableClassId, [In] string scheme);
		[Overload("RegisterSchemeHandlerWithSettings")]
		void RegisterSchemeHandler([In] string activatableClassId, [In] string scheme, [In] IPropertySet configuration);
		[Overload("RegisterByteStreamHandler")]
		void RegisterByteStreamHandler([In] string activatableClassId, [In] string fileExtension, [In] string mimeType);
		[Overload("RegisterByteStreamHandlerWithSettings")]
		void RegisterByteStreamHandler([In] string activatableClassId, [In] string fileExtension, [In] string mimeType, [In] IPropertySet configuration);
		[Overload("RegisterAudioDecoder")]
		void RegisterAudioDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
		[Overload("RegisterAudioDecoderWithSettings")]
		void RegisterAudioDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
		[Overload("RegisterAudioEncoder")]
		void RegisterAudioEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
		[Overload("RegisterAudioEncoderWithSettings")]
		void RegisterAudioEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
		[Overload("RegisterVideoDecoder")]
		void RegisterVideoDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
		[Overload("RegisterVideoDecoderWithSettings")]
		void RegisterVideoDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
		[Overload("RegisterVideoEncoder")]
		void RegisterVideoEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
		[Overload("RegisterVideoEncoderWithSettings")]
		void RegisterVideoEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
	}
}
