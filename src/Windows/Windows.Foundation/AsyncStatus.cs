using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Version(100794368u)]
	public enum AsyncStatus
	{
		Canceled = 2,
		Completed = 1,
		Error = 3,
		Started = 0
	}
}
