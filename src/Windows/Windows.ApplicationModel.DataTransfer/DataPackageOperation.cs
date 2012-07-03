using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[Version(100794368u)]
	public enum DataPackageOperation
	{
		None,
		Copy,
		Move,
		Link = 4
	}
}
