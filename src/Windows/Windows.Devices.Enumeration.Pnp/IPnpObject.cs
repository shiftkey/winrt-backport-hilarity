using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration.Pnp
{
	[ExclusiveTo(typeof(PnpObject)), Guid(2512806488u, 29499, 19087, 147, 163, 219, 7, 138, 200, 112, 193), Version(100794368u)]
	internal interface IPnpObject
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
		void Update([In] PnpObjectUpdate updateInfo);
	}
}
