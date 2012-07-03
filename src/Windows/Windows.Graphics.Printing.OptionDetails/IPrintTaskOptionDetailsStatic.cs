using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[ExclusiveTo(typeof(PrintTaskOptionDetails)), Guid(324903315u, 2401, 19310, 135, 102, 241, 59, 127, 188, 205, 88), Version(100794368u)]
	internal interface IPrintTaskOptionDetailsStatic
	{
		PrintTaskOptionDetails GetFromPrintTaskOptions([In] PrintTaskOptions printTaskOptions);
	}
}
