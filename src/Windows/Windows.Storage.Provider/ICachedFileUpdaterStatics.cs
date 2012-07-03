using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[ExclusiveTo(typeof(CachedFileUpdater)), Guid(2680752416u, 31695, 18568, 168, 30, 16, 45, 112, 52, 215, 206), Version(100794368u)]
	internal interface ICachedFileUpdaterStatics
	{
		void SetUpdateInformation([In] IStorageFile file, [In] string contentId, [In] ReadActivationMode readMode, [In] WriteActivationMode writeMode, [In] CachedFileOptions options);
	}
}
