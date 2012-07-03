using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	public sealed class StorageItemQueryResult : IStorageItemQueryResult, IStorageQueryResultBase
	{
	    public event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;
	    public event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;
		public extern StorageFolder Folder
		{
			get;
		}
		[Overload("GetItemsAsync")]
		public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync([In] uint startIndex, [In] uint maxNumberOfItems);
		[Overload("GetItemsAsyncDefaultStartAndCount")]
		public extern IAsyncOperation<IVectorView<IStorageItem>> GetItemsAsync();
		public extern IAsyncOperation<uint> GetItemCountAsync();
		public extern IAsyncOperation<uint> FindStartIndexAsync([Variant] [In] object value);
		public extern QueryOptions GetCurrentQueryOptions();
		public extern void ApplyNewQueryOptions([In] QueryOptions newQueryOptions);
	}
}
