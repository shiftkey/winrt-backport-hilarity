using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel
{
	[ExclusiveTo(typeof(Package)), Guid(1314081759u, 10592, 18552, 151, 164, 150, 36, 222, 183, 47, 45), Version(100794368u)]
	internal interface IPackageStatics
	{
		Package Current
		{
			get;
		}
	}
}
