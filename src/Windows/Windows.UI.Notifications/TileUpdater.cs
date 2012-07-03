using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[Version(100794368u)]
	public sealed class TileUpdater : ITileUpdater
	{
		public extern NotificationSetting Setting
		{
			get;
		}
		public extern void Update([In] TileNotification notification);
		public extern void Clear();
		public extern void EnableNotificationQueue([In] bool enable);
		public extern void AddToSchedule([In] ScheduledTileNotification scheduledTile);
		public extern void RemoveFromSchedule([In] ScheduledTileNotification scheduledTile);
		public extern IVectorView<ScheduledTileNotification> GetScheduledTileNotifications();
		[Overload("StartPeriodicUpdate")]
		public extern void StartPeriodicUpdate([In] Uri tileContent, [In] PeriodicUpdateRecurrence requestedInterval);
		[Overload("StartPeriodicUpdateAtTime")]
		public extern void StartPeriodicUpdate([In] Uri tileContent, [In] DateTime startTime, [In] PeriodicUpdateRecurrence requestedInterval);
		public extern void StopPeriodicUpdate();
		[Overload("StartPeriodicUpdateBatch")]
		public extern void StartPeriodicUpdateBatch([In] IIterable<Uri> tileContents, [In] PeriodicUpdateRecurrence requestedInterval);
		[Overload("StartPeriodicUpdateBatchAtTime")]
		public extern void StartPeriodicUpdateBatch([In] IIterable<Uri> tileContents, [In] DateTime startTime, [In] PeriodicUpdateRecurrence requestedInterval);
	}
}
