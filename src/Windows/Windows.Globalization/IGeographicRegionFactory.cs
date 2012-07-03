using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[ExclusiveTo(typeof(GeographicRegion)), Guid(1396855408u, 30644, 17003, 133, 159, 129, 225, 157, 81, 37, 70), Version(100794368u)]
	internal interface IGeographicRegionFactory
	{
		GeographicRegion CreateGeographicRegion([In] string geographicRegionCode);
	}
}
