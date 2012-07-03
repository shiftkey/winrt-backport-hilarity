using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.NumberFormatting
{
	[ExclusiveTo(typeof(PermilleFormatter)), Guid(725071020u, 58936, 20181, 169, 152, 98, 246, 176, 106, 73, 174), Version(100794368u)]
	internal interface IPermilleFormatterFactory
	{
		PermilleFormatter CreatePermilleFormatter([In] IIterable<string> languages, [In] string geographicRegion);
	}
}
