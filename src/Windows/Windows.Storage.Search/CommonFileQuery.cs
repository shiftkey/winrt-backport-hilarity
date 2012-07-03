using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[Version(100794368u)]
	public enum CommonFileQuery
	{
		DefaultQuery,
		OrderByName,
		OrderByTitle,
		OrderByMusicProperties,
		OrderBySearchRank,
		OrderByDate
	}
}
