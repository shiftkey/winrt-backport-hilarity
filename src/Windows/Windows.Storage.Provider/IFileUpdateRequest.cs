using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[ExclusiveTo(typeof(FileUpdateRequest))]
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
