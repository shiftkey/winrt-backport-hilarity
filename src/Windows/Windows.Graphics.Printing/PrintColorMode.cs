using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Version(100794368u)]
	public enum PrintColorMode
	{
		Default,
		NotAvailable,
		PrinterCustom,
		Color,
		Grayscale,
		Monochrome
	}
}
