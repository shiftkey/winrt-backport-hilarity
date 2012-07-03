using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading.Core
{
	[ExclusiveTo(typeof(PreallocatedWorkItem)), Guid(3822267205u, 57322, 18075, 130, 197, 246, 227, 206, 253, 234, 251), Version(100794368u), WebHostHidden]
	internal interface IPreallocatedWorkItemFactory
	{
		PreallocatedWorkItem CreateWorkItem([In] WorkItemHandler handler);
		PreallocatedWorkItem CreateWorkItemWithPriority([In] WorkItemHandler handler, [In] WorkItemPriority priority);
		PreallocatedWorkItem CreateWorkItemWithPriorityAndOptions([In] WorkItemHandler handler, [In] WorkItemPriority priority, [In] WorkItemOptions options);
	}
}
