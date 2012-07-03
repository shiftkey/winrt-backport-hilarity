using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Notifications
{
	[ExclusiveTo(typeof(TileUpdater)), Guid(155362443u, 7569, 17644, 146, 67, 193, 232, 33, 194, 154, 32), Version(100794368u)]
	internal interface ITileUpdater
	{
		NotificationSetting Setting
		{
			get;
		}
		void Update([In] TileNotification notification);
		void Clear();
		void EnableNotificationQueue([In] bool enable);
		void AddToSchedule([In] ScheduledTileNotification scheduledTile);
		void RemoveFromSchedule([In] ScheduledTileNotification scheduledTile);
		IVectorView<ScheduledTileNotification> GetScheduledTileNotifications();
		[Overload("StartPeriodicUpdate")]
		void StartPeriodicUpdate([In] Uri tileContent, [In] PeriodicUpdateRecurrence requestedInterval);
		[Overload("StartPeriodicUpdateAtTime")]
		void StartPeriodicUpdate([In] Uri tileContent, [In] DateTime startTime, [In] PeriodicUpdateRecurrence requestedInterval);
		void StopPeriodicUpdate();
		[Overload("StartPeriodicUpdateBatch")]
		void StartPeriodicUpdateBatch([In] IIterable<Uri> tileContents, [In] PeriodicUpdateRecurrence requestedInterval);
		[Overload("StartPeriodicUpdateBatchAtTime")]
		void StartPeriodicUpdateBatch([In] IIterable<Uri> tileContents, [In] DateTime startTime, [In] PeriodicUpdateRecurrence requestedInterval);
	}
}
