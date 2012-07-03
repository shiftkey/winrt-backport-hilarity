using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[Version(100794368u)]
	public enum CommonFolderQuery
	{
		DefaultQuery,
		GroupByYear = 100,
		GroupByMonth,
		GroupByArtist,
		GroupByAlbum,
		GroupByAlbumArtist,
		GroupByComposer,
		GroupByGenre,
		GroupByPublishedYear,
		GroupByRating,
		GroupByTag,
		GroupByAuthor,
		GroupByType
	}
}
