using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.AccessCache
{
	[Guid(749729453u, 56976, 18421, 178, 195, 221, 54, 201, 253, 212, 83), Version(100794368u)]
	public interface IStorageItemAccessList
	{
		AccessListEntryView Entries
		{
			get;
		}
		uint MaximumItemsAllowed
		{
			get;
		}
		[Overload("AddOverloadDefaultMetadata")]
		string Add([In] IStorageItem file);
		[Overload("Add")]
		string Add([In] IStorageItem file, [In] string metadata);
		[Overload("AddOrReplaceOverloadDefaultMetadata")]
		void AddOrReplace([In] string token, [In] IStorageItem file);
		[Overload("AddOrReplace")]
		void AddOrReplace([In] string token, [In] IStorageItem file, [In] string metadata);
		[Overload("GetItemAsync")]
		IAsyncOperation<IStorageItem> GetItemAsync([In] string token);
		[Overload("GetFileAsync")]
		IAsyncOperation<StorageFile> GetFileAsync([In] string token);
		[Overload("GetFolderAsync")]
		IAsyncOperation<StorageFolder> GetFolderAsync([In] string token);
		[Overload("GetItemWithOptionsAsync")]
		IAsyncOperation<IStorageItem> GetItemAsync([In] string token, [In] AccessCacheOptions options);
		[Overload("GetFileWithOptionsAsync")]
		IAsyncOperation<StorageFile> GetFileAsync([In] string token, [In] AccessCacheOptions options);
		[Overload("GetFolderWithOptionsAsync")]
		IAsyncOperation<StorageFolder> GetFolderAsync([In] string token, [In] AccessCacheOptions options);
		void Remove([In] string token);
		bool ContainsItem([In] string token);
		void Clear();
		bool CheckAccess([In] IStorageItem file);
	}
}
