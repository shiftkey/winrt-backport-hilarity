using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.NumberFormatting
{
	[ExclusiveTo(typeof(CurrencyFormatter)), Guid(2261209982u, 47416, 19106, 132, 176, 44, 51, 220, 91, 20, 80), Version(100794368u)]
	internal interface ICurrencyFormatterFactory
	{
		CurrencyFormatter CreateCurrencyFormatterCode([In] string currencyCode);
		CurrencyFormatter CreateCurrencyFormatterCodeContext([In] string currencyCode, [In] IIterable<string> languages, [In] string geographicRegion);
	}
}
