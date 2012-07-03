using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[Flags, Version(100794368u)]
	public enum DataClasses : uint
	{
		None = 0u,
		Gprs = 1u,
		Edge = 2u,
		Umts = 4u,
		Hsdpa = 8u,
		Hsupa = 16u,
		LteAdvanced = 32u,
		Cdma1xRtt = 65536u,
		Cdma1xEvdo = 131072u,
		Cdma1xEvdoRevA = 262144u,
		Cdma1xEvdv = 524288u,
		Cdma3xRtt = 1048576u,
		Cdma1xEvdoRevB = 2097152u,
		CdmaUmb = 4194304u,
		Custom = 2147483648u
	}
}
