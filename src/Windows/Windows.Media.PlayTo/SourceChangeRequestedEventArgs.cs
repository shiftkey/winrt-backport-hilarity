using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Media.PlayTo
{
	[Version(100794368u)]
	public sealed class SourceChangeRequestedEventArgs : ISourceChangeRequestedEventArgs
	{
		public extern string Album
		{
			get;
		}
		public extern string Author
		{
			get;
		}
		public extern IReference<DateTime> Date
		{
			get;
		}
		public extern string Description
		{
			get;
		}
		public extern string Genre
		{
			get;
		}
		public extern IMapView<string, object> Properties
		{
			get;
		}
		public extern IReference<uint> Rating
		{
			get;
		}
		public extern IRandomAccessStreamWithContentType Stream
		{
			get;
		}
		public extern IRandomAccessStreamReference Thumbnail
		{
			get;
		}
		public extern string Title
		{
			get;
		}
	}
}
