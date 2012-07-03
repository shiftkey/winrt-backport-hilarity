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
	[ExclusiveTo(typeof(MediaTranscoder)), Guid(420256210u, 41130, 19764, 134, 188, 238, 209, 177, 44, 47, 91), Version(100794368u)]
	internal interface IMediaTranscoder
	{
		bool AlwaysReencode
		{
			get;
			set;
		}
		bool HardwareAccelerationEnabled
		{
			get;
			set;
		}
		TimeSpan TrimStartTime
		{
			get;
			set;
		}
		TimeSpan TrimStopTime
		{
			get;
			set;
		}
		[Overload("AddAudioEffect")]
		void AddAudioEffect([In] string activatableClassId);
		[Overload("AddAudioEffectWithSettings")]
		void AddAudioEffect([In] string activatableClassId, [In] bool effectRequired, [In] IPropertySet configuration);
		[Overload("AddVideoEffect")]
		void AddVideoEffect([In] string activatableClassId);
		[Overload("AddVideoEffectWithSettings")]
		void AddVideoEffect([In] string activatableClassId, [In] bool effectRequired, [In] IPropertySet configuration);
		void ClearEffects();
		IAsyncOperation<PrepareTranscodeResult> PrepareFileTranscodeAsync([In] IStorageFile source, [In] IStorageFile destination, [In] MediaEncodingProfile profile);
		IAsyncOperation<PrepareTranscodeResult> PrepareStreamTranscodeAsync([In] IRandomAccessStream source, [In] IRandomAccessStream destination, [In] MediaEncodingProfile profile);
	}
}
