using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[ExclusiveTo(typeof(CachedFileUpdater))]
	internal interface ICachedFileUpdaterStatics
	{
		void SetUpdateInformation([In] IStorageFile file, [In] string contentId, [In] ReadActivationMode readMode, [In] WriteActivationMode writeMode, [In] CachedFileOptions options);
	}
}
