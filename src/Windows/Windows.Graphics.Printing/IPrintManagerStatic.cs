using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[ExclusiveTo(typeof(PrintManager)), Guid(1477991885u, 58932, 18004, 132, 240, 224, 21, 42, 130, 23, 172), Version(100794368u)]
	internal interface IPrintManagerStatic
	{
		PrintManager GetForCurrentView();
		IAsyncOperation<bool> ShowPrintUIAsync();
	}
}
