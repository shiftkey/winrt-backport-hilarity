using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[DualApiPartition(version = 100794368u), Version(100794368u)]
	public sealed class ToastFailedEventArgs : IToastFailedEventArgs
	{
		public extern HResult ErrorCode
		{
			get;
		}
	}
}
