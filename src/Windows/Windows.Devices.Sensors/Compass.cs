using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICompassStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class Compass : ICompass
	{
		public extern event TypedEventHandler<Compass, CompassReadingChangedEventArgs> ReadingChanged
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
		public extern CompassReading GetCurrentReading();
		public static extern Compass GetDefault();
	}
}
