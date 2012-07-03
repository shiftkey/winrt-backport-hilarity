using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.BackgroundTransfer
{
	[ExclusiveTo(typeof(BackgroundUploader)), Guid(4068957435u, 39685, 18241, 145, 33, 116, 10, 131, 226, 71, 223), Version(100794368u)]
	internal interface IBackgroundUploaderStaticMethods
	{
		[Overload("GetCurrentUploadsAsync")]
		IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync();
		[Overload("GetCurrentUploadsForGroupAsync")]
		IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync([In] string group);
	}
}
