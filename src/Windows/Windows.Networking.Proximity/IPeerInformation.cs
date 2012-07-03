using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Proximity
{
	[ExclusiveTo(typeof(PeerInformation)), Guid(537022216u, 40959, 17908, 182, 233, 64, 139, 46, 190, 243, 115), Version(100794368u)]
	internal interface IPeerInformation
	{
		string DisplayName
		{
			get;
		}
	}
}
