using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Static(typeof(IWebUIActivationStatics), 100794368u), Version(100794368u)]
	public static class WebUIApplication
	{
		public static extern event ActivatedEventHandler Activated
		{
			add;
			remove;
		}
		public static extern event ResumingEventHandler Resuming
		{
			add;
			remove;
		}
		public static extern event SuspendingEventHandler Suspending
		{
			add;
			remove;
		}
	}
}
