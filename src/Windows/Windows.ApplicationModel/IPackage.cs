using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.ApplicationModel
{
	[ExclusiveTo(typeof(Package)), Guid(373061935u, 48501, 16700, 191, 35, 177, 254, 123, 149, 216, 37), Version(100794368u)]
	internal interface IPackage
	{
		IVectorView<Package> Dependencies
		{
			get;
		}
		PackageId Id
		{
			get;
		}
		StorageFolder InstalledLocation
		{
			get;
		}
		bool IsFramework
		{
			get;
		}
	}
}
