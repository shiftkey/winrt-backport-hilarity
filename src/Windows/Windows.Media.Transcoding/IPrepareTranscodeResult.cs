using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.Transcoding
{
	[ExclusiveTo(typeof(PrepareTranscodeResult)), Guid(99769806u, 39247, 18996, 157, 104, 151, 204, 206, 23, 48, 214), Version(100794368u)]
	internal interface IPrepareTranscodeResult
	{
		bool CanTranscode
		{
			get;
		}
		TranscodeFailureReason FailureReason
		{
			get;
		}
		IAsyncActionWithProgress<double> TranscodeAsync();
	}
}
