using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(StorageFolder)), Guid(150153215u, 34261, 18617, 174, 233, 40, 81, 30, 51, 159, 159), Version(100794368u)]
	internal interface IStorageFolderStatics
	{
		IAsyncOperation<StorageFolder> GetFolderFromPathAsync([In] string path);
	}
}
