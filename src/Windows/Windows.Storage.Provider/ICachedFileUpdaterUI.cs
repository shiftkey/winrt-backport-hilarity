using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[ExclusiveTo(typeof(CachedFileUpdaterUI)), Guid(2658091494u, 47858, 19095, 182, 0, 147, 51, 245, 223, 128, 253), Version(100794368u)]
	internal interface ICachedFileUpdaterUI
	{
		event TypedEventHandler<CachedFileUpdaterUI, FileUpdateRequestedEventArgs> FileUpdateRequested;
		event TypedEventHandler<CachedFileUpdaterUI, object> UIRequested;
		string Title
		{
			get;
			set;
		}
		UIStatus UIStatus
		{
			get;
		}
		CachedFileTarget UpdateTarget
		{
			get;
		}
	}
}
