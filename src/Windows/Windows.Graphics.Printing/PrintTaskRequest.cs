using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintTaskRequest : IPrintTaskRequest
	{
		public extern DateTime Deadline
		{
			get;
		}
		public extern PrintTask CreatePrintTask([In] string title, [In] PrintTaskSourceRequestedHandler handler);
		public extern PrintTaskRequestedDeferral GetDeferral();
	}
}
