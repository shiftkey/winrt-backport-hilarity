using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Printers.Extensions
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintNotificationEventDetails : IPrintNotificationEventDetails
	{
		public extern string EventData
		{
			get;
			set;
		}
		public extern string PrinterName
		{
			get;
		}
	}
}
