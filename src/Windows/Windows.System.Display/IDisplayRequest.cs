using System;
using Windows.Foundation.Metadata;
namespace Windows.System.Display
{
	[ExclusiveTo(typeof(DisplayRequest)), Guid(3849527364u, 62623, 19296, 141, 212, 94, 126, 58, 99, 42, 192), Version(100794368u)]
	internal interface IDisplayRequest
	{
		void RequestActive();
		void RequestRelease();
	}
}
