using Windows.Foundation;
using Windows.Foundation.Collections;

namespace Windows.Storage.Search
{
	public class StorageFolderQueryResult : IStorageFolderQueryResult
	{
	    public event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;

	    public event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;

	    public StorageFolder Folder { get; private set; }
	
		
		public IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(uint startIndex, uint maxNumberOfItems) { }

        public IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync() { }
        public IAsyncOperation<uint> GetItemCountAsync() { }
        public IAsyncOperation<uint> FindStartIndexAsync(object value) { }
        public QueryOptions GetCurrentQueryOptions() { }
        public void ApplyNewQueryOptions(QueryOptions newQueryOptions) { }
	}
}
