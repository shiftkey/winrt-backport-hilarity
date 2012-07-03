using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IThreadPoolStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public static class ThreadPool
	{
		[Overload("RunAsync")]
		public static extern IAsyncAction RunAsync([In] WorkItemHandler handler);
		[Overload("RunWithPriorityAsync")]
		public static extern IAsyncAction RunAsync([In] WorkItemHandler handler, [In] WorkItemPriority priority);
		[Overload("RunWithPriorityAndOptionsAsync")]
		public static extern IAsyncAction RunAsync([In] WorkItemHandler handler, [In] WorkItemPriority priority, [In] WorkItemOptions options);
	}
}
