using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[ExclusiveTo(typeof(QueryOptions)), Guid(53354380u, 43457, 20081, 128, 17, 13, 238, 157, 72, 17, 163), Version(100794368u)]
	internal interface IQueryOptionsFactory
	{
		QueryOptions CreateCommonFileQuery([In] CommonFileQuery query, [In] IIterable<string> fileTypeFilter);
		QueryOptions CreateCommonFolderQuery([In] CommonFolderQuery query);
	}
}
