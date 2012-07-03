using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPrintManagerStatic), 100794368u), Version(100794368u)]
	public sealed class PrintManager : IPrintManager
	{
		public extern event TypedEventHandler<PrintManager, PrintTaskRequestedEventArgs> PrintTaskRequested
		{
			add;
			remove;
		}
		public static extern PrintManager GetForCurrentView();
		public static extern IAsyncOperation<bool> ShowPrintUIAsync();
	}
}
