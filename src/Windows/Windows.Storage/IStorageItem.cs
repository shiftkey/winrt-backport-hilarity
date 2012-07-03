using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
namespace Windows.Storage
{
	[Guid(1107798422u, 51759, 17143, 189, 232, 139, 16, 69, 122, 127, 48), Version(100794368u)]
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
