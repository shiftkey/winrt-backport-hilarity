using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[ExclusiveTo(typeof(GeographicRegion)), Guid(702712180u, 31449, 20212, 135, 153, 179, 180, 79, 173, 236, 8), Version(100794368u)]
	internal interface IGeographicRegionStatics
	{
		bool IsSupported([In] string geographicRegionCode);
	}
}
