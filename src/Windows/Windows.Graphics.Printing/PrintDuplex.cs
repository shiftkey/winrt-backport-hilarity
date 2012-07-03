using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Version(100794368u)]
	public enum PrintDuplex
	{
		Default,
		NotAvailable,
		PrinterCustom,
		OneSided,
		TwoSidedShortEdge,
		TwoSidedLongEdge
	}
}
