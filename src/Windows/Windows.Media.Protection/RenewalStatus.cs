using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[Version(100794368u)]
	public enum RenewalStatus
	{
		NotStarted,
		UpdatesInProgress,
		UserCancelled,
		AppComponentsMayNeedUpdating,
		NoComponentsFound
	}
}
