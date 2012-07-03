using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Version(100794368u)]
	public enum PrintBinding
	{
		Default,
		NotAvailable,
		PrinterCustom,
		None,
		Bale,
		BindBottom,
		BindLeft,
		BindRight,
		BindTop,
		Booklet,
		EdgeStitchBottom,
		EdgeStitchLeft,
		EdgeStitchRight,
		EdgeStitchTop,
		Fold,
		JogOffset,
		Trim
	}
}
