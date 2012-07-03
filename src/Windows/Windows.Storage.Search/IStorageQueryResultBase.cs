using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[Guid(3264730893u, 29523, 18347, 186, 88, 140, 97, 66, 93, 197, 75), Version(100794368u)]
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
