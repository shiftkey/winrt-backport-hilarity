using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Version(100794368u)]
	public enum PrintCollation
	{
		Default,
		NotAvailable,
		PrinterCustom,
		Collated,
		Uncollated
	}
}
