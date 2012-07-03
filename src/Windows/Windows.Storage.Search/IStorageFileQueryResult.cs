using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[ExclusiveTo(typeof(StorageFileQueryResult)), Guid(1392354375u, 11178, 16684, 178, 159, 212, 177, 119, 142, 250, 30), Version(100794368u)]
	internal interface IStorageFileQueryResult : IStorageQueryResultBase
	{
		[Overload("GetFilesAsync")]
		IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] uint startIndex, [In] uint maxNumberOfItems);
		[Overload("GetFilesAsyncDefaultStartAndCount")]
		IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();
	}
}
