using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration.Pnp
{
	[ExclusiveTo(typeof(PnpObjectUpdate)), Guid(1868163090u, 30, 18500, 188, 198, 67, 40, 134, 133, 106, 23), Version(100794368u)]
	internal interface IPnpObjectUpdate
	{
		string Id
		{
			get;
		}
		IMapView<string, object> Properties
		{
			[return: HasVariant]
			get;
		}
		PnpObjectType Type
		{
			get;
		}
	}
}
