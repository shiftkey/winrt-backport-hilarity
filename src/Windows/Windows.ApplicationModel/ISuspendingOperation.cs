using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel
{
	[Guid(2644822593u, 8417, 20123, 159, 101, 169, 244, 53, 52, 12, 58), Version(100794368u)]
	public interface ISuspendingOperation
	{
		DateTime Deadline
		{
			get;
		}
		SuspendingDeferral GetDeferral();
	}
}
