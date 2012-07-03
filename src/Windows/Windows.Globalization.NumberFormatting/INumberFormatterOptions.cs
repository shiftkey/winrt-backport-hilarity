using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.NumberFormatting
{
	[Guid(2150837537u, 44769, 19001, 186, 162, 7, 237, 140, 150, 218, 246), Version(100794368u)]
	public interface INumberFormatterOptions
	{
		int FractionDigits
		{
			get;
			set;
		}
		string GeographicRegion
		{
			get;
		}
		int IntegerDigits
		{
			get;
			set;
		}
		bool IsDecimalPointAlwaysDisplayed
		{
			get;
			set;
		}
		bool IsGrouped
		{
			get;
			set;
		}
		IVectorView<string> Languages
		{
			get;
		}
		string NumeralSystem
		{
			get;
			set;
		}
		string ResolvedGeographicRegion
		{
			get;
		}
		string ResolvedLanguage
		{
			get;
		}
	}
}
