using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[Version(100794368u)]
	public sealed class StorageFolderQueryResult : IStorageFolderQueryResult, IStorageQueryResultBase
	{
		public extern event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged
		{
			add;
			remove;
		}
		public extern StorageFolder Folder
		{
			get;
		}
		[Overload("GetFoldersAsync")]
		public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync([In] uint startIndex, [In] uint maxNumberOfItems);
		[Overload("GetFoldersAsyncDefaultStartAndCount")]
		public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();
		public extern IAsyncOperation<uint> GetItemCountAsync();
		public extern IAsyncOperation<uint> FindStartIndexAsync([Variant] [In] object value);
		public extern QueryOptions GetCurrentQueryOptions();
		public extern void ApplyNewQueryOptions([In] QueryOptions newQueryOptions);
	}
}
