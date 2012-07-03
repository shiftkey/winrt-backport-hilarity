using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Version(100794368u)]
	public enum PrintHolePunch
	{
		Default,
		NotAvailable,
		PrinterCustom,
		None,
		LeftEdge,
		RightEdge,
		TopEdge,
		BottomEdge
	}
}
