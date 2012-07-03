using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using DateTime = Windows.Foundation.DateTime;

namespace Windows.Storage
{
	public interface IStorageItem
	{
		FileAttributes Attributes
		{
			get;
		}
		DateTime DateCreated
		{
			get;
		}
		string Name
		{
			get;
		}
		string Path
		{
			get;
		}
		[Overload("RenameAsyncOverloadDefaultOptions")]
		IAsyncAction RenameAsync([In] string desiredName);
		[Overload("RenameAsync")]
		IAsyncAction RenameAsync([In] string desiredName, [In] NameCollisionOption option);
		[Overload("DeleteAsyncOverloadDefaultOptions")]
		IAsyncAction DeleteAsync();
		[Overload("DeleteAsync")]
		IAsyncAction DeleteAsync([In] StorageDeleteOption option);
		IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();
		bool IsOfType([In] StorageItemTypes type);
	}
}
