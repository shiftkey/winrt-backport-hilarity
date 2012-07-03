using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[Version(100794368u)]
	public sealed class StorageFileQueryResult : IStorageFileQueryResult, IStorageQueryResultBase
	{
	    public event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;
	    public event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;
		public extern StorageFolder Folder
		{
			get;
		}
		[Overload("GetFilesAsync")]
		public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] uint startIndex, [In] uint maxNumberOfItems);
		[Overload("GetFilesAsyncDefaultStartAndCount")]
		public extern IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();
		public extern IAsyncOperation<uint> GetItemCountAsync();
		public extern IAsyncOperation<uint> FindStartIndexAsync([Variant] [In] object value);
		public extern QueryOptions GetCurrentQueryOptions();
		public extern void ApplyNewQueryOptions([In] QueryOptions newQueryOptions);
	}
}
