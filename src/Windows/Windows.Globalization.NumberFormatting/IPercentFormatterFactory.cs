using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.NumberFormatting
{
	[ExclusiveTo(typeof(PercentFormatter)), Guid(3078785775u, 65236, 16408, 166, 226, 224, 153, 97, 224, 55, 101), Version(100794368u)]
	internal interface IPercentFormatterFactory
	{
		PercentFormatter CreatePercentFormatter([In] IIterable<string> languages, [In] string geographicRegion);
	}
}
