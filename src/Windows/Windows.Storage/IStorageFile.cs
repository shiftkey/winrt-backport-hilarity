using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Storage
{
	[Guid(4198457734u, 16916, 17036, 166, 76, 20, 201, 172, 115, 21, 234), Version(100794368u)]
	public interface IStorageFile : IStorageItem, IRandomAccessStreamReference, IInputStreamReference
	{
		string ContentType
		{
			get;
		}
		string FileType
		{
			get;
		}
		IAsyncOperation<IRandomAccessStream> OpenAsync([In] FileAccessMode accessMode);
		IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync();
		[Overload("CopyOverloadDefaultNameAndOptions")]
		IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder);
		[Overload("CopyOverloadDefaultOptions")]
		IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName);
		[Overload("CopyOverload")]
		IAsyncOperation<StorageFile> CopyAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName, [In] NameCollisionOption option);
		IAsyncAction CopyAndReplaceAsync([In] IStorageFile fileToReplace);
		[Overload("MoveOverloadDefaultNameAndOptions")]
		IAsyncAction MoveAsync([In] IStorageFolder destinationFolder);
		[Overload("MoveOverloadDefaultOptions")]
		IAsyncAction MoveAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName);
		[Overload("MoveOverload")]
		IAsyncAction MoveAsync([In] IStorageFolder destinationFolder, [In] string desiredNewName, [In] NameCollisionOption option);
		IAsyncAction MoveAndReplaceAsync([In] IStorageFile fileToReplace);
	}
}
