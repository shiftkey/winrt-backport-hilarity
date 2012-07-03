using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration.Pnp
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPnpObjectStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PnpObject : IPnpObject
	{
		public extern string Id
		{
			get;
		}
		public extern IMapView<string, object> Properties
		{
			[return: HasVariant]
			get;
		}
		public extern PnpObjectType Type
		{
			get;
		}
		public extern void Update([In] PnpObjectUpdate updateInfo);
		public static extern IAsyncOperation<PnpObject> CreateFromIdAsync([In] PnpObjectType type, [In] string id, [In] IIterable<string> requestedProperties);
		[DefaultOverload, Overload("FindAllAsync")]
		public static extern IAsyncOperation<PnpObjectCollection> FindAllAsync([In] PnpObjectType type, [In] IIterable<string> requestedProperties);
		[DefaultOverload, Overload("FindAllAsyncAqsFilter")]
		public static extern IAsyncOperation<PnpObjectCollection> FindAllAsync([In] PnpObjectType type, [In] IIterable<string> requestedProperties, [In] string aqsFilter);
		[DefaultOverload, Overload("CreateWatcher")]
		public static extern PnpObjectWatcher CreateWatcher([In] PnpObjectType type, [In] IIterable<string> requestedProperties);
		[DefaultOverload, Overload("CreateWatcherAqsFilter")]
		public static extern PnpObjectWatcher CreateWatcher([In] PnpObjectType type, [In] IIterable<string> requestedProperties, [In] string aqsFilter);
	}
}
