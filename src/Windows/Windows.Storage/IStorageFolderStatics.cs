using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(StorageFolder))]
	internal interface IStorageFolderStatics
	{
		IAsyncOperation<StorageFolder> GetFolderFromPathAsync([In] string path);
	}
}
