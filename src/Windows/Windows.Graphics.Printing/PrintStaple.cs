using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Version(100794368u)]
	public enum PrintStaple
	{
		Default,
		NotAvailable,
		PrinterCustom,
		None,
		StapleTopLeft,
		StapleTopRight,
		StapleBottomLeft,
		StapleBottomRight,
		StapleDualLeft,
		StapleDualRight,
		StapleDualTop,
		StapleDualBottom,
		SaddleStitch
	}
}
