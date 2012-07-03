using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class Geolocator : IGeolocator
	{
		public extern event TypedEventHandler<Geolocator, PositionChangedEventArgs> PositionChanged
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<Geolocator, StatusChangedEventArgs> StatusChanged
		{
			add;
			remove;
		}
		public extern PositionAccuracy DesiredAccuracy
		{
			get;
			set;
		}
		public extern PositionStatus LocationStatus
		{
			get;
		}
		public extern double MovementThreshold
		{
			get;
			set;
		}
		public extern uint ReportInterval
		{
			get;
			set;
		}
		public extern Geolocator();
		[DefaultOverload, Overload("GetGeopositionAsync")]
		public extern IAsyncOperation<Geoposition> GetGeopositionAsync();
		[DefaultOverload, Overload("GetGeopositionAsyncWithAgeAndTimeout")]
		public extern IAsyncOperation<Geoposition> GetGeopositionAsync([In] TimeSpan maximumAge, [In] TimeSpan timeout);
	}
}
