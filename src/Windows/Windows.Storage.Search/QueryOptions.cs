using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
namespace Windows.Storage.Search
{
	[Activatable(typeof(IQueryOptionsFactory), 100794368u), Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class QueryOptions : IQueryOptions
	{
		public extern string ApplicationSearchFilter
		{
			get;
			set;
		}
		public extern DateStackOption DateStackOption
		{
			get;
		}
		public extern IVector<string> FileTypeFilter
		{
			get;
		}
		public extern FolderDepth FolderDepth
		{
			get;
			set;
		}
		public extern string GroupPropertyName
		{
			get;
		}
		public extern IndexerOption IndexerOption
		{
			get;
			set;
		}
		public extern string Language
		{
			get;
			set;
		}
		public extern IVector<SortEntry> SortOrder
		{
			get;
		}
		public extern string UserSearchFilter
		{
			get;
			set;
		}
		public extern QueryOptions([In] CommonFileQuery query, [In] IIterable<string> fileTypeFilter);
		public extern QueryOptions([In] CommonFolderQuery query);
		public extern QueryOptions();
		public extern string SaveToString();
		public extern void LoadFromString([In] string value);
		public extern void SetThumbnailPrefetch([In] ThumbnailMode mode, [In] uint requestedSize, [In] ThumbnailOptions options);
		public extern void SetPropertyPrefetch([In] PropertyPrefetchOptions options, [In] IIterable<string> propertiesToRetrieve);
	}
}
