using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[MarshalingBehavior(MarshalingType.Standard), Static(typeof(IWebUIBackgroundTaskInstanceStatics), 100794368u), Version(100794368u)]
	public static class WebUIBackgroundTaskInstance
	{
		public static extern IWebUIBackgroundTaskInstance Current
		{
			get;
		}
	}
}
