using System;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.NumberFormatting
{
	[ExclusiveTo(typeof(CurrencyFormatter)), Guid(292752549u, 19200, 16818, 179, 50, 115, 177, 42, 73, 125, 84), Version(100794368u)]
	internal interface ICurrencyFormatter : INumberFormatterOptions, INumberFormatter, INumberParser
	{
		string Currency
		{
			get;
			set;
		}
	}
}
