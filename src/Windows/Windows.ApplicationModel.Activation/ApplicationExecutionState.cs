using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Version(100794368u)]
	public enum ApplicationExecutionState
	{
		NotRunning,
		Running,
		Suspended,
		Terminated,
		ClosedByUser
	}
}
