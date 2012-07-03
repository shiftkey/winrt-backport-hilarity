using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(LanIdentifier)), Guid(1219122090u, 4360, 17734, 166, 203, 154, 116, 218, 75, 123, 160), Version(100794368u)]
	internal interface ILanIdentifier
	{
		LanIdentifierData InfrastructureId
		{
			get;
		}
		Guid NetworkAdapterId
		{
			get;
		}
		LanIdentifierData PortId
		{
			get;
		}
	}
}
