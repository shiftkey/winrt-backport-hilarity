using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(IPInformation)), Guid(3629204960u, 5007, 18391, 155, 58, 54, 187, 72, 140, 239, 51), Version(100794368u)]
	internal interface IIPInformation
	{
		NetworkAdapter NetworkAdapter
		{
			get;
		}
		IReference<byte> PrefixLength
		{
			get;
		}
	}
}
