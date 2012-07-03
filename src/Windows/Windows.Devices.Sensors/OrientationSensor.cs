using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IOrientationSensorStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class OrientationSensor : IOrientationSensor
	{
		public extern event TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs> ReadingChanged
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
		public extern OrientationSensorReading GetCurrentReading();
		public static extern OrientationSensor GetDefault();
	}
}
