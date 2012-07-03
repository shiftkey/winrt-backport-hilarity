using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[Version(100794368u)]
	public enum NetworkEncryptionType
	{
		None,
		Unknown,
		Wep,
		Wep40,
		Wep104,
		Tkip,
		Ccmp,
		WpaUseGroup,
		RsnUseGroup,
		Ihv
	}
}
