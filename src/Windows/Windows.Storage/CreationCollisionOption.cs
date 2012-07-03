using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[Version(100794368u)]
	public enum CreationCollisionOption
	{
		GenerateUniqueName,
		ReplaceExisting,
		FailIfExists,
		OpenIfExists
	}
}
