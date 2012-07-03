using System;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IClockIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class ClockIdentifiers
	{
		public static extern string TwelveHour
		{
			get;
		}
		public static extern string TwentyFourHour
		{
			get;
		}
	}
}
