using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.DataProtection
{
	[ExclusiveTo(typeof(DataProtectionProvider)), Guid(157522248u, 60706, 17008, 189, 28, 109, 114, 192, 15, 135, 135), Version(100794368u)]
	internal interface IDataProtectionProvider
	{
		IAsyncOperation<IBuffer> ProtectAsync([In] IBuffer data);
		IAsyncOperation<IBuffer> UnprotectAsync([In] IBuffer data);
		IAsyncAction ProtectStreamAsync([In] IInputStream src, [In] IOutputStream dest);
		IAsyncAction UnprotectStreamAsync([In] IInputStream src, [In] IOutputStream dest);
	}
}
