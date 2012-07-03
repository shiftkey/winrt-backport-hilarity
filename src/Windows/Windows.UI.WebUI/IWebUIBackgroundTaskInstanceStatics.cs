using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[ExclusiveTo(typeof(WebUIBackgroundTaskInstance)), Guid(2625262225u, 6574, 19619, 185, 75, 254, 78, 199, 68, 167, 64), Version(100794368u)]
	internal interface IWebUIBackgroundTaskInstanceStatics
	{
		IWebUIBackgroundTaskInstance Current
		{
			get;
		}
	}
}
