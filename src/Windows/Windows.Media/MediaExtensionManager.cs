using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class MediaExtensionManager : IMediaExtensionManager
	{
		public extern MediaExtensionManager();
		[Overload("RegisterSchemeHandler")]
		public extern void RegisterSchemeHandler([In] string activatableClassId, [In] string scheme);
		[Overload("RegisterSchemeHandlerWithSettings")]
		public extern void RegisterSchemeHandler([In] string activatableClassId, [In] string scheme, [In] IPropertySet configuration);
		[Overload("RegisterByteStreamHandler")]
		public extern void RegisterByteStreamHandler([In] string activatableClassId, [In] string fileExtension, [In] string mimeType);
		[Overload("RegisterByteStreamHandlerWithSettings")]
		public extern void RegisterByteStreamHandler([In] string activatableClassId, [In] string fileExtension, [In] string mimeType, [In] IPropertySet configuration);
		[Overload("RegisterAudioDecoder")]
		public extern void RegisterAudioDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
		[Overload("RegisterAudioDecoderWithSettings")]
		public extern void RegisterAudioDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
		[Overload("RegisterAudioEncoder")]
		public extern void RegisterAudioEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
		[Overload("RegisterAudioEncoderWithSettings")]
		public extern void RegisterAudioEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
		[Overload("RegisterVideoDecoder")]
		public extern void RegisterVideoDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
		[Overload("RegisterVideoDecoderWithSettings")]
		public extern void RegisterVideoDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
		[Overload("RegisterVideoEncoder")]
		public extern void RegisterVideoEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
		[Overload("RegisterVideoEncoderWithSettings")]
		public extern void RegisterVideoEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
	}
}
