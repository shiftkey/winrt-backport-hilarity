using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading.Core
{
	[Activatable(typeof(IPreallocatedWorkItemFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PreallocatedWorkItem : IPreallocatedWorkItem
	{
		public extern PreallocatedWorkItem([In] WorkItemHandler handler);
		public extern PreallocatedWorkItem([In] WorkItemHandler handler, [In] WorkItemPriority priority);
		public extern PreallocatedWorkItem([In] WorkItemHandler handler, [In] WorkItemPriority priority, [In] WorkItemOptions options);
		public extern IAsyncAction RunAsync();
	}
}
