using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[ExclusiveTo(typeof(QueryOptions))]
	internal interface IQueryOptionsFactory
	{
		QueryOptions CreateCommonFileQuery([In] CommonFileQuery query, [In] IIterable<string> fileTypeFilter);
		QueryOptions CreateCommonFolderQuery([In] CommonFolderQuery query);
	}
}
