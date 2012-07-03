using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(CoreDispatcher)), Guid(1624977320u, 46853, 20446, 167, 214, 235, 187, 24, 145, 211, 158), Version(100794368u), WebHostHidden]
	internal interface ICoreDispatcher : ICoreAcceleratorKeys
	{
		bool HasThreadAccess
		{
			get;
		}
		void ProcessEvents([In] CoreProcessEventsOption options);
		IAsyncAction RunAsync([In] CoreDispatcherPriority priority, [In] DispatchedHandler agileCallback);
		IAsyncAction RunIdleAsync([In] IdleDispatchedHandler agileCallback);
	}
}
