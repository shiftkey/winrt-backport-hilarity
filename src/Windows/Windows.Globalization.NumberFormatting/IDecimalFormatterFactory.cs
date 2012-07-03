using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.NumberFormatting
{
	[ExclusiveTo(typeof(DecimalFormatter)), Guid(218205338u, 58259, 18104, 184, 48, 122, 105, 200, 248, 159, 187), Version(100794368u)]
	internal interface IDecimalFormatterFactory
	{
		DecimalFormatter CreateDecimalFormatter([In] IIterable<string> languages, [In] string geographicRegion);
	}
}
