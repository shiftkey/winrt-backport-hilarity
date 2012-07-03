using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[Version(100794368u)]
	public enum ApplicationDataLocality
	{
		Local,
		Roaming,
		Temporary
	}
}
