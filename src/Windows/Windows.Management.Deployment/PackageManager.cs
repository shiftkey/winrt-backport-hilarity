using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Management.Deployment
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class PackageManager : IPackageManager
	{
		public extern PackageManager();
		public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
		public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> UpdatePackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
		public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageAsync([In] string packageFullName);
		public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris);
		public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageAsync([In] Uri manifestUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
		[Overload("FindPackages")]
		public extern IIterable<Package> FindPackages();
		[Overload("FindPackagesByUserSecurityId")]
		public extern IIterable<Package> FindPackagesForUser([In] string userSecurityId);
		[Overload("FindPackagesByNamePublisher")]
		public extern IIterable<Package> FindPackages([In] string packageName, [In] string packagePublisher);
		[Overload("FindPackagesByUserSecurityIdNamePublisher")]
		public extern IIterable<Package> FindPackagesForUser([In] string userSecurityId, [In] string packageName, [In] string packagePublisher);
		public extern IIterable<PackageUserInformation> FindUsers([In] string packageFullName);
		public extern void SetPackageState([In] string packageFullName, [In] PackageState packageState);
		[Overload("FindPackageByPackageFullName")]
		public extern Package FindPackage([In] string packageFullName);
		public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> CleanupPackageForUserAsync([In] string packageName, [In] string userSecurityId);
		[Overload("FindPackagesByPackageFamilyName")]
		public extern IIterable<Package> FindPackages([In] string packageFamilyName);
		[Overload("FindPackagesByUserSecurityIdPackageFamilyName")]
		public extern IIterable<Package> FindPackagesForUser([In] string userSecurityId, [In] string packageFamilyName);
		[Overload("FindPackageByUserSecurityIdPackageFullName")]
		public extern Package FindPackageForUser([In] string userSecurityId, [In] string packageFullName);
	}
}
