using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Sensors
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class InclinometerReadingChangedEventArgs : IInclinometerReadingChangedEventArgs
	{
		public extern InclinometerReading Reading
		{
			get;
		}
	}
}
