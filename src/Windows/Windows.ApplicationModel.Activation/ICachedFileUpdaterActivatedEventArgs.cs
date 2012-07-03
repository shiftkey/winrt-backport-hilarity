using System;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;
namespace Windows.ApplicationModel.Activation
{
	[Guid(3496915399u, 14341, 20171, 183, 87, 108, 241, 94, 38, 254, 243), Version(100794368u)]
	public interface ICachedFileUpdaterActivatedEventArgs : IActivatedEventArgs
	{
		CachedFileUpdaterUI CachedFileUpdaterUI
		{
			get;
		}
	}
}
