using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration.Pnp
{
	[ExclusiveTo(typeof(PnpObject)), Guid(3015911997u, 53608, 18016, 187, 243, 167, 51, 177, 75, 110, 1), Version(100794368u)]
	internal interface IPnpObjectStatics
	{
		IAsyncOperation<PnpObject> CreateFromIdAsync([In] PnpObjectType type, [In] string id, [In] IIterable<string> requestedProperties);
		[DefaultOverload, Overload("FindAllAsync")]
		IAsyncOperation<PnpObjectCollection> FindAllAsync([In] PnpObjectType type, [In] IIterable<string> requestedProperties);
		[DefaultOverload, Overload("FindAllAsyncAqsFilter")]
		IAsyncOperation<PnpObjectCollection> FindAllAsync([In] PnpObjectType type, [In] IIterable<string> requestedProperties, [In] string aqsFilter);
		[DefaultOverload, Overload("CreateWatcher")]
		PnpObjectWatcher CreateWatcher([In] PnpObjectType type, [In] IIterable<string> requestedProperties);
		[DefaultOverload, Overload("CreateWatcherAqsFilter")]
		PnpObjectWatcher CreateWatcher([In] PnpObjectType type, [In] IIterable<string> requestedProperties, [In] string aqsFilter);
	}
}
