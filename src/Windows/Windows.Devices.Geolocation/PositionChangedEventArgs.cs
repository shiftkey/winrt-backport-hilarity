using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PositionChangedEventArgs : IPositionChangedEventArgs
	{
		public extern Geoposition Position
		{
			get;
		}
	}
}
