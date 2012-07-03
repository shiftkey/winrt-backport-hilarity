using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(BadgeUpdater)), Guid(3053068244u, 30050, 20332, 191, 163, 27, 110, 210, 229, 127, 47), Version(100794368u)]
	internal interface IBadgeUpdater
	{
		void Update([In] BadgeNotification notification);
		void Clear();
		[Overload("StartPeriodicUpdate")]
		void StartPeriodicUpdate([In] Uri badgeContent, [In] PeriodicUpdateRecurrence requestedInterval);
		[Overload("StartPeriodicUpdateAtTime")]
		void StartPeriodicUpdate([In] Uri badgeContent, [In] DateTime startTime, [In] PeriodicUpdateRecurrence requestedInterval);
		void StopPeriodicUpdate();
	}
}
