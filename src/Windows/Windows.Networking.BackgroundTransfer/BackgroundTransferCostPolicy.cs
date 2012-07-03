using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.BackgroundTransfer
{
	[Version(100794368u)]
	public enum BackgroundTransferCostPolicy
	{
		Default,
		UnrestrictedOnly,
		Always
	}
}
