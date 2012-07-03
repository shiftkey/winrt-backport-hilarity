using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.NumberFormatting
{
	[Guid(3865416722u, 18963, 19027, 131, 161, 57, 47, 190, 76, 255, 159), Version(100794368u)]
	public interface INumberParser
	{
		IReference<long> ParseInt([In] string text);
		IReference<ulong> ParseUInt([In] string text);
		IReference<double> ParseDouble([In] string text);
	}
}
