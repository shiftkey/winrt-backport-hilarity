using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(ToastDismissedEventArgs)), Guid(1065998645u, 55755, 17720, 160, 240, 255, 231, 101, 153, 56, 248), Version(100794368u)]
	internal interface IToastDismissedEventArgs
	{
		ToastDismissalReason Reason
		{
			get;
		}
	}
}
