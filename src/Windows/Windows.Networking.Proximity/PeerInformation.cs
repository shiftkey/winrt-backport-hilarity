using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Proximity
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PeerInformation : IPeerInformation
	{
		public extern string DisplayName
		{
			get;
		}
	}
}
