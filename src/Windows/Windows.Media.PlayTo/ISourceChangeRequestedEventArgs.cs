using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(SourceChangeRequestedEventArgs)), Guid(4215224982u, 31398, 19083, 134, 231, 84, 246, 198, 211, 79, 100), Version(100794368u)]
	internal interface ISourceChangeRequestedEventArgs
	{
		string Album
		{
			get;
		}
		string Author
		{
			get;
		}
		IReference<DateTime> Date
		{
			get;
		}
		string Description
		{
			get;
		}
		string Genre
		{
			get;
		}
		IMapView<string, object> Properties
		{
			get;
		}
		IReference<uint> Rating
		{
			get;
		}
		IRandomAccessStreamWithContentType Stream
		{
			get;
		}
		IRandomAccessStreamReference Thumbnail
		{
			get;
		}
		string Title
		{
			get;
		}
	}
}
