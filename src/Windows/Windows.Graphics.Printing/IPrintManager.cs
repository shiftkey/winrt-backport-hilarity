using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[ExclusiveTo(typeof(PrintManager)), Guid(4280981140u, 35993, 17661, 174, 74, 25, 217, 170, 154, 15, 10), Version(100794368u)]
	internal interface IPrintManager
	{
		event TypedEventHandler<PrintManager, PrintTaskRequestedEventArgs> PrintTaskRequested;
	}
}
