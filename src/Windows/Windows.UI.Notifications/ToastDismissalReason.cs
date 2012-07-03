using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[Version(100794368u)]
	public enum ToastDismissalReason
	{
		UserCanceled,
		ApplicationHidden,
		TimedOut
	}
}
