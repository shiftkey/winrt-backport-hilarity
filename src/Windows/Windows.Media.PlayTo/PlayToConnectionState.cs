using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[Version(100794368u)]
	public enum PlayToConnectionState
	{
		Disconnected,
		Connected,
		Rendering
	}
}
