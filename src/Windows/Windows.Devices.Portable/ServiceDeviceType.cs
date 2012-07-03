using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Portable
{
	[Version(100794368u)]
	public enum ServiceDeviceType
	{
		CalendarService,
		ContactsService,
		DeviceStatusService,
		NotesService,
		RingtonesService,
		SmsService,
		TasksService
	}
}
