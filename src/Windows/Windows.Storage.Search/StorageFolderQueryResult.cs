using Windows.Foundation;
using Windows.Foundation.Collections;

namespace Windows.Storage.Search
{
	public class StorageFolderQueryResult : IStorageFolderQueryResult
	{
	    public event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;

	    public event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;

	    public StorageFolder Folder { get; private set; }


	    public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync(uint startIndex, uint maxNumberOfItems);

        public extern IAsyncOperation<IVectorView<StorageFolder>> GetFoldersAsync();
	    public extern IAsyncOperation<uint> GetItemCountAsync();
	    public extern IAsyncOperation<uint> FindStartIndexAsync(object value);
	    public extern QueryOptions GetCurrentQueryOptions();
        public void ApplyNewQueryOptions(QueryOptions newQueryOptions) { }
	}
}
