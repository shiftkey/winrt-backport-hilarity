using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.Media.Transcoding
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class MediaTranscoder : IMediaTranscoder
	{
		public extern bool AlwaysReencode
		{
			get;
			set;
		}
		public extern bool HardwareAccelerationEnabled
		{
			get;
			set;
		}
		public extern TimeSpan TrimStartTime
		{
			get;
			set;
		}
		public extern TimeSpan TrimStopTime
		{
			get;
			set;
		}
		public extern MediaTranscoder();
		[Overload("AddAudioEffect")]
		public extern void AddAudioEffect([In] string activatableClassId);
		[Overload("AddAudioEffectWithSettings")]
		public extern void AddAudioEffect([In] string activatableClassId, [In] bool effectRequired, [In] IPropertySet configuration);
		[Overload("AddVideoEffect")]
		public extern void AddVideoEffect([In] string activatableClassId);
		[Overload("AddVideoEffectWithSettings")]
		public extern void AddVideoEffect([In] string activatableClassId, [In] bool effectRequired, [In] IPropertySet configuration);
		public extern void ClearEffects();
		public extern IAsyncOperation<PrepareTranscodeResult> PrepareFileTranscodeAsync([In] IStorageFile source, [In] IStorageFile destination, [In] MediaEncodingProfile profile);
		public extern IAsyncOperation<PrepareTranscodeResult> PrepareStreamTranscodeAsync([In] IRandomAccessStream source, [In] IRandomAccessStream destination, [In] MediaEncodingProfile profile);
	}
}
