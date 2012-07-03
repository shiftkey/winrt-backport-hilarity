using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[Version(100794368u)]
	public enum PlayToConnectionError
	{
		None,
		DeviceNotResponding,
		DeviceError,
		DeviceLocked
	}
}
