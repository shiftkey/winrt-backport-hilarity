using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Printers.Extensions
{
	[ExclusiveTo(typeof(PrintNotificationEventDetails)), Guid(3759033482u, 18472, 19873, 139, 184, 134, 114, 223, 133, 21, 231), Version(100794368u)]
	internal interface IPrintNotificationEventDetails
	{
		string EventData
		{
			get;
			set;
		}
		string PrinterName
		{
			get;
		}
	}
}
