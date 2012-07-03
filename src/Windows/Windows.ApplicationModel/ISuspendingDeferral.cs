using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel
{
	[Guid(1494484233u, 35785, 20148, 182, 54, 218, 189, 196, 244, 111, 102), Version(100794368u)]
	public interface ISuspendingDeferral
	{
		void Complete();
	}
}
