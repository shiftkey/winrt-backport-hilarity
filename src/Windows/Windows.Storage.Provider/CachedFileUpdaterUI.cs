using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[Version(100794368u)]
	public sealed class CachedFileUpdaterUI : ICachedFileUpdaterUI
	{
		public extern event TypedEventHandler<CachedFileUpdaterUI, FileUpdateRequestedEventArgs> FileUpdateRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CachedFileUpdaterUI, object> UIRequested
		{
			add;
			remove;
		}
		public extern string Title
		{
			get;
			set;
		}
		public extern UIStatus UIStatus
		{
			get;
		}
		public extern CachedFileTarget UpdateTarget
		{
			get;
		}
	}
}
