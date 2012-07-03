using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Media.PlayTo
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PlayToSourceSelectedEventArgs : IPlayToSourceSelectedEventArgs
	{
		public extern string FriendlyName
		{
			get;
		}
		public extern IRandomAccessStreamWithContentType Icon
		{
			get;
		}
		public extern bool SupportsAudio
		{
			get;
		}
		public extern bool SupportsImage
		{
			get;
		}
		public extern bool SupportsVideo
		{
			get;
		}
	}
}
