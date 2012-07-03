using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading
{
	[ExclusiveTo(typeof(ThreadPool)), Guid(3065997277u, 33981, 17656, 172, 28, 147, 235, 203, 157, 186, 145), Version(100794368u), WebHostHidden]
	internal interface IThreadPoolStatics
	{
		[Overload("RunAsync")]
		IAsyncAction RunAsync([In] WorkItemHandler handler);
		[Overload("RunWithPriorityAsync")]
		IAsyncAction RunAsync([In] WorkItemHandler handler, [In] WorkItemPriority priority);
		[Overload("RunWithPriorityAndOptionsAsync")]
		IAsyncAction RunAsync([In] WorkItemHandler handler, [In] WorkItemPriority priority, [In] WorkItemOptions options);
	}
}
