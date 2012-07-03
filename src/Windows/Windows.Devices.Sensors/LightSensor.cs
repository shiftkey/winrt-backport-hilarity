using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ILightSensorStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class LightSensor : ILightSensor
	{
		public extern event TypedEventHandler<LightSensor, LightSensorReadingChangedEventArgs> ReadingChanged
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
		public extern LightSensorReading GetCurrentReading();
		public static extern LightSensor GetDefault();
	}
}
