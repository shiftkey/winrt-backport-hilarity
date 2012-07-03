using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[DualApiPartition(version = 100794368u), Version(100794368u)]
	public sealed class ToastDismissedEventArgs : IToastDismissedEventArgs
	{
		public extern ToastDismissalReason Reason
		{
			get;
		}
	}
}
