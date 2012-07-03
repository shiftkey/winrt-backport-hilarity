using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u), WebHostHidden]
	public sealed class CoreDispatcher : ICoreDispatcher, ICoreAcceleratorKeys
	{
		public extern event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> AcceleratorKeyActivated
		{
			add;
			remove;
		}
		public extern bool HasThreadAccess
		{
			get;
		}
		public extern void ProcessEvents([In] CoreProcessEventsOption options);
		public extern IAsyncAction RunAsync([In] CoreDispatcherPriority priority, [In] DispatchedHandler agileCallback);
		public extern IAsyncAction RunIdleAsync([In] IdleDispatchedHandler agileCallback);
	}
}
