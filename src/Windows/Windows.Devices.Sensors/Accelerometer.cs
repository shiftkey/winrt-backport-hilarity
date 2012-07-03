using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IAccelerometerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class Accelerometer : IAccelerometer
	{
		public extern event TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs> ReadingChanged
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<Accelerometer, AccelerometerShakenEventArgs> Shaken
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
		public extern AccelerometerReading GetCurrentReading();
		public static extern Accelerometer GetDefault();
	}
}
