using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.ApplicationModel
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPackageStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class Package : IPackage
	{
		public extern IVectorView<Package> Dependencies
		{
			get;
		}
		public extern PackageId Id
		{
			get;
		}
		public extern StorageFolder InstalledLocation
		{
			get;
		}
		public extern bool IsFramework
		{
			get;
		}
		public static extern Package Current
		{
			get;
		}
	}
}
