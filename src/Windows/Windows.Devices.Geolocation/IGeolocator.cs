using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Geolocation
{
	[ExclusiveTo(typeof(Geolocator)), Guid(2848178018u, 17700, 18825, 138, 169, 222, 1, 157, 46, 85, 31), Version(100794368u)]
	internal interface IGeolocator
	{
		event TypedEventHandler<Geolocator, PositionChangedEventArgs> PositionChanged;
		event TypedEventHandler<Geolocator, StatusChangedEventArgs> StatusChanged;
		PositionAccuracy DesiredAccuracy
		{
			get;
			set;
		}
		PositionStatus LocationStatus
		{
			get;
		}
		double MovementThreshold
		{
			get;
			set;
		}
		uint ReportInterval
		{
			get;
			set;
		}
		[DefaultOverload, Overload("GetGeopositionAsync")]
		IAsyncOperation<Geoposition> GetGeopositionAsync();
		[DefaultOverload, Overload("GetGeopositionAsyncWithAgeAndTimeout")]
		IAsyncOperation<Geoposition> GetGeopositionAsync([In] TimeSpan maximumAge, [In] TimeSpan timeout);
	}
}
