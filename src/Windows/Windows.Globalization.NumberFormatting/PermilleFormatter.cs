using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.NumberFormatting
{
	[Activatable(typeof(IPermilleFormatterFactory), 100794368u), Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PermilleFormatter : INumberFormatterOptions, INumberFormatter, INumberParser
	{
		public extern int FractionDigits
		{
			get;
			set;
		}
		public extern string GeographicRegion
		{
			get;
		}
		public extern int IntegerDigits
		{
			get;
			set;
		}
		public extern bool IsDecimalPointAlwaysDisplayed
		{
			get;
			set;
		}
		public extern bool IsGrouped
		{
			get;
			set;
		}
		public extern IVectorView<string> Languages
		{
			get;
		}
		public extern string NumeralSystem
		{
			get;
			set;
		}
		public extern string ResolvedGeographicRegion
		{
			get;
		}
		public extern string ResolvedLanguage
		{
			get;
		}
		public extern PermilleFormatter([In] IIterable<string> languages, [In] string geographicRegion);
		public extern PermilleFormatter();
		[Overload("FormatInt")]
		public extern string Format([In] long value);
		[Overload("FormatUInt")]
		public extern string Format([In] ulong value);
		[DefaultOverload, Overload("FormatDouble")]
		public extern string Format([In] double value);
		public extern IReference<long> ParseInt([In] string text);
		public extern IReference<ulong> ParseUInt([In] string text);
		public extern IReference<double> ParseDouble([In] string text);
	}
}
