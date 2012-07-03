using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[ExclusiveTo(typeof(StorageFileQueryResult))]
	internal interface IStorageFileQueryResult : IStorageQueryResultBase
	{
		[Overload("GetFilesAsync")]
		IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync([In] uint startIndex, [In] uint maxNumberOfItems);
		[Overload("GetFilesAsyncDefaultStartAndCount")]
		IAsyncOperation<IVectorView<StorageFile>> GetFilesAsync();
	}
}
