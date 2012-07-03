using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[ExclusiveTo(typeof(WebUIApplication)), Guid(890996413u, 17331, 18475, 133, 219, 53, 216, 123, 81, 122, 217), Version(100794368u)]
	internal interface IWebUIActivationStatics
	{
		event ActivatedEventHandler Activated;
		event ResumingEventHandler Resuming;
		event SuspendingEventHandler Suspending;
	}
}
