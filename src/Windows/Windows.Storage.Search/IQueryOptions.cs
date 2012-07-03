using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
namespace Windows.Storage.Search
{
	[ExclusiveTo(typeof(QueryOptions))]
	internal interface IQueryOptions
	{
		string ApplicationSearchFilter
		{
			get;
			set;
		}
		DateStackOption DateStackOption
		{
			get;
		}
		IVector<string> FileTypeFilter
		{
			get;
		}
		FolderDepth FolderDepth
		{
			get;
			set;
		}
		string GroupPropertyName
		{
			get;
		}
		IndexerOption IndexerOption
		{
			get;
			set;
		}
		string Language
		{
			get;
			set;
		}
		IVector<SortEntry> SortOrder
		{
			get;
		}
		string UserSearchFilter
		{
			get;
			set;
		}
		string SaveToString();
		void LoadFromString([In] string value);
		void SetThumbnailPrefetch([In] ThumbnailMode mode, [In] uint requestedSize, [In] ThumbnailOptions options);
		void SetPropertyPrefetch([In] PropertyPrefetchOptions options, [In] IIterable<string> propertiesToRetrieve);
	}
}
