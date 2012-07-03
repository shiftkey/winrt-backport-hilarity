using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Version(100794368u)]
	public enum PrintOrientation
	{
		Default,
		NotAvailable,
		PrinterCustom,
		Portrait,
		PortraitFlipped,
		Landscape,
		LandscapeFlipped
	}
}
