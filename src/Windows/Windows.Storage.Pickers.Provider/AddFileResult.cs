using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[Version(100794368u)]
	public enum AddFileResult
	{
		Added,
		AlreadyAdded,
		NotAllowed,
		Unavailable
	}
}
