using Windows.Foundation;

namespace Windows.Storage.Provider
{
	public sealed class CachedFileUpdaterUI : ICachedFileUpdaterUI
	{
	    public event TypedEventHandler<CachedFileUpdaterUI, FileUpdateRequestedEventArgs> FileUpdateRequested;

	    public event TypedEventHandler<CachedFileUpdaterUI, object> UIRequested;
		
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
