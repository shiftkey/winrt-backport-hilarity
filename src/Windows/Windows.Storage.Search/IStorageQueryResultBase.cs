using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	public interface IStorageQueryResultBase
	{
		event TypedEventHandler<IStorageQueryResultBase, object> ContentsChanged;
		event TypedEventHandler<IStorageQueryResultBase, object> OptionsChanged;
		StorageFolder Folder
		{
			get;
		}
		IAsyncOperation<uint> GetItemCountAsync();
		IAsyncOperation<uint> FindStartIndexAsync([Variant] [In] object value);
		QueryOptions GetCurrentQueryOptions();
		void ApplyNewQueryOptions([In] QueryOptions newQueryOptions);
	}
}
