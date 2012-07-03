using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.NumberFormatting
{
	[Guid(2768272457u, 30326, 19895, 134, 49, 27, 111, 242, 101, 202, 169), Version(100794368u)]
	public interface INumberFormatter
	{
		[Overload("FormatInt")]
		string Format([In] long value);
		[Overload("FormatUInt")]
		string Format([In] ulong value);
		[DefaultOverload, Overload("FormatDouble")]
		string Format([In] double value);
	}
}
