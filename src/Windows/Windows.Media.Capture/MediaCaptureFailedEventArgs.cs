using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Capture
{
	[MarshalingBehavior(MarshalingType.Standard), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class MediaCaptureFailedEventArgs : IMediaCaptureFailedEventArgs
	{
		public extern uint Code
		{
			get;
		}
		public extern string Message
		{
			get;
		}
	}
}
