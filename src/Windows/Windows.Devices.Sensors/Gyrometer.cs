using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGyrometerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class Gyrometer : IGyrometer
	{
		public extern event TypedEventHandler<Gyrometer, GyrometerReadingChangedEventArgs> ReadingChanged
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
		public extern GyrometerReading GetCurrentReading();
		public static extern Gyrometer GetDefault();
	}
}
