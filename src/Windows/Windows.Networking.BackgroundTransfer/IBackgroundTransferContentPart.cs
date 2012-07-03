using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Networking.BackgroundTransfer
{
	[ExclusiveTo(typeof(BackgroundTransferContentPart)), Guid(3907081815u, 55249, 20184, 131, 142, 103, 74, 194, 23, 172, 230), Version(100794368u)]
	internal interface IBackgroundTransferContentPart
	{
		void SetHeader([In] string headerName, [In] string headerValue);
		void SetText([In] string value);
		void SetFile([In] IStorageFile value);
	}
}
