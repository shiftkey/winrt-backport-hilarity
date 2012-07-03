using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[ExclusiveTo(typeof(FileUpdateRequest)), Guid(1086858550u, 49662, 19859, 167, 146, 30, 115, 107, 199, 8, 55), Version(100794368u)]
	internal interface IFileUpdateRequest
	{
		string ContentId
		{
			get;
		}
		StorageFile File
		{
			get;
		}
		FileUpdateStatus Status
		{
			get;
			set;
		}
		FileUpdateRequestDeferral GetDeferral();
		void UpdateLocalFile([In] IStorageFile value);
	}
}
