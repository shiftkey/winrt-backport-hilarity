using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(LanIdentifierData)), Guid(2806940611u, 54841, 17854, 163, 106, 196, 228, 174, 175, 109, 155), Version(100794368u)]
	internal interface ILanIdentifierData
	{
		uint Type
		{
			get;
		}
		IVectorView<byte> Value
		{
			get;
		}
	}
}
