using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.Transcoding
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PrepareTranscodeResult : IPrepareTranscodeResult
	{
		public extern bool CanTranscode
		{
			get;
		}
		public extern TranscodeFailureReason FailureReason
		{
			get;
		}
		public extern IAsyncActionWithProgress<double> TranscodeAsync();
	}
}
