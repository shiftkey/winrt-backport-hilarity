using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading
{
	[Guid(488278923u, 64102, 16719, 156, 189, 182, 95, 201, 157, 23, 250), Version(100794368u), WebHostHidden]
	public delegate void WorkItemHandler([In] IAsyncAction operation);
}
