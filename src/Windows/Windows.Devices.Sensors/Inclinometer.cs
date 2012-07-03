using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IInclinometerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class Inclinometer : IInclinometer
	{
		public extern event TypedEventHandler<Inclinometer, InclinometerReadingChangedEventArgs> ReadingChanged
		{
			add;
			remove;
		}
		public extern uint MinimumReportInterval
		{
			get;
		}
		public extern uint ReportInterval
		{
			get;
			set;
		}
		public extern InclinometerReading GetCurrentReading();
		public static extern Inclinometer GetDefault();
	}
}
