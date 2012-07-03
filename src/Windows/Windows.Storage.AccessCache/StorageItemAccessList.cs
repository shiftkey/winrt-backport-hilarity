using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.AccessCache
{
	[Version(100794368u)]
	public sealed class StorageItemAccessList : IStorageItemAccessList
	{
		public extern AccessListEntryView Entries
		{
			get;
		}
		public extern uint MaximumItemsAllowed
		{
			get;
		}
		[Overload("AddOverloadDefaultMetadata")]
		public extern string Add([In] IStorageItem file);
		[Overload("Add")]
		public extern string Add([In] IStorageItem file, [In] string metadata);
		[Overload("AddOrReplaceOverloadDefaultMetadata")]
		public extern void AddOrReplace([In] string token, [In] IStorageItem file);
		[Overload("AddOrReplace")]
		public extern void AddOrReplace([In] string token, [In] IStorageItem file, [In] string metadata);
		[Overload("GetItemAsync")]
		public extern IAsyncOperation<IStorageItem> GetItemAsync([In] string token);
		[Overload("GetFileAsync")]
		public extern IAsyncOperation<StorageFile> GetFileAsync([In] string token);
		[Overload("GetFolderAsync")]
		public extern IAsyncOperation<StorageFolder> GetFolderAsync([In] string token);
		[Overload("GetItemWithOptionsAsync")]
		public extern IAsyncOperation<IStorageItem> GetItemAsync([In] string token, [In] AccessCacheOptions options);
		[Overload("GetFileWithOptionsAsync")]
		public extern IAsyncOperation<StorageFile> GetFileAsync([In] string token, [In] AccessCacheOptions options);
		[Overload("GetFolderWithOptionsAsync")]
		public extern IAsyncOperation<StorageFolder> GetFolderAsync([In] string token, [In] AccessCacheOptions options);
		public extern void Remove([In] string token);
		public extern bool ContainsItem([In] string token);
		public extern void Clear();
		public extern bool CheckAccess([In] IStorageItem file);
	}
}
