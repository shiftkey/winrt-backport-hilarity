using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[Version(100794368u)]
	public enum FileUpdateStatus
	{
		Incomplete,
		Complete,
		UserInputNeeded,
		CurrentlyUnavailable,
		Failed,
		CompleteAndRenamed
	}
}
