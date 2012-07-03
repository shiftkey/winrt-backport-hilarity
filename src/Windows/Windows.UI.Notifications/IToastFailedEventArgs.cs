using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(ToastFailedEventArgs)), Guid(890726498u, 53204, 17656, 173, 100, 245, 0, 253, 137, 108, 59), Version(100794368u)]
	internal interface IToastFailedEventArgs
	{
		HResult ErrorCode
		{
			get;
		}
	}
}
