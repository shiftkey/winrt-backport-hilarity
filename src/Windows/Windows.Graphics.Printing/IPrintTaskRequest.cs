using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[ExclusiveTo(typeof(PrintTaskRequest)), Guid(1878400558u, 10018, 16960, 166, 124, 243, 100, 132, 154, 23, 243), Version(100794368u)]
	internal interface IPrintTaskRequest
	{
		DateTime Deadline
		{
			get;
		}
		PrintTask CreatePrintTask([In] string title, [In] PrintTaskSourceRequestedHandler handler);
		PrintTaskRequestedDeferral GetDeferral();
	}
}
