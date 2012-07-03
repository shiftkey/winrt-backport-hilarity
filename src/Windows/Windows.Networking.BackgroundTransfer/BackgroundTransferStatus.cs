using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.BackgroundTransfer
{
	[Version(100794368u)]
	public enum BackgroundTransferStatus
	{
		Idle,
		Running,
		PausedByApplication,
		PausedCostedNetwork,
		PausedNoNetwork,
		Completed,
		Canceled,
		Error
	}
}
