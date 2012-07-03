using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICachedFileUpdaterStatics), 100794368u), Version(100794368u)]
	public static class CachedFileUpdater
	{
		public static extern void SetUpdateInformation([In] IStorageFile file, [In] string contentId, [In] ReadActivationMode readMode, [In] WriteActivationMode writeMode, [In] CachedFileOptions options);
	}
}
