using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PlayToSourceRequestedEventArgs : IPlayToSourceRequestedEventArgs
	{
		public extern PlayToSourceRequest SourceRequest
		{
			get;
		}
	}
}
