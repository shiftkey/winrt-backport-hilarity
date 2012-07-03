using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class StatusChangedEventArgs : IStatusChangedEventArgs
	{
		public extern PositionStatus Status
		{
			get;
		}
	}
}
