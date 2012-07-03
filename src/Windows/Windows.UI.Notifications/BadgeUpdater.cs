using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[Version(100794368u)]
	public sealed class BadgeUpdater : IBadgeUpdater
	{
		public extern void Update([In] BadgeNotification notification);
		public extern void Clear();
		[Overload("StartPeriodicUpdate")]
		public extern void StartPeriodicUpdate([In] Uri badgeContent, [In] PeriodicUpdateRecurrence requestedInterval);
		[Overload("StartPeriodicUpdateAtTime")]
		public extern void StartPeriodicUpdate([In] Uri badgeContent, [In] DateTime startTime, [In] PeriodicUpdateRecurrence requestedInterval);
		public extern void StopPeriodicUpdate();
	}
}
