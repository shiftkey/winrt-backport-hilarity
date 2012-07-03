using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration.Pnp
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PnpObjectUpdate : IPnpObjectUpdate
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
	}
}
