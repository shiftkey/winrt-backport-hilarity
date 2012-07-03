using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[Version(100794368u)]
	public sealed class FileUpdateRequest : IFileUpdateRequest
	{
		public extern string ContentId
		{
			get;
		}
		public extern StorageFile File
		{
			get;
		}
		public extern FileUpdateStatus Status
		{
			get;
			set;
		}
		public extern FileUpdateRequestDeferral GetDeferral();
		public extern void UpdateLocalFile([In] IStorageFile value);
	}
}
