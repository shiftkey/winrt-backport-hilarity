using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Management.Deployment
{
	[ExclusiveTo(typeof(PackageManager)), Guid(2591902565u, 24207, 20423, 162, 229, 127, 105, 37, 203, 139, 83), Version(100794368u)]
	internal interface IPackageManager
	{
		IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
		IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> UpdatePackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
		IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageAsync([In] string packageFullName);
		IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync([In] Uri packageUri, [In] IIterable<Uri> dependencyPackageUris);
		IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageAsync([In] Uri manifestUri, [In] IIterable<Uri> dependencyPackageUris, [In] DeploymentOptions deploymentOptions);
		[Overload("FindPackages")]
		IIterable<Package> FindPackages();
		[Overload("FindPackagesByUserSecurityId")]
		IIterable<Package> FindPackagesForUser([In] string userSecurityId);
		[Overload("FindPackagesByNamePublisher")]
		IIterable<Package> FindPackages([In] string packageName, [In] string packagePublisher);
		[Overload("FindPackagesByUserSecurityIdNamePublisher")]
		IIterable<Package> FindPackagesForUser([In] string userSecurityId, [In] string packageName, [In] string packagePublisher);
		IIterable<PackageUserInformation> FindUsers([In] string packageFullName);
		void SetPackageState([In] string packageFullName, [In] PackageState packageState);
		[Overload("FindPackageByPackageFullName")]
		Package FindPackage([In] string packageFullName);
		IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> CleanupPackageForUserAsync([In] string packageName, [In] string userSecurityId);
		[Overload("FindPackagesByPackageFamilyName")]
		IIterable<Package> FindPackages([In] string packageFamilyName);
		[Overload("FindPackagesByUserSecurityIdPackageFamilyName")]
		IIterable<Package> FindPackagesForUser([In] string userSecurityId, [In] string packageFamilyName);
		[Overload("FindPackageByUserSecurityIdPackageFullName")]
		Package FindPackageForUser([In] string userSecurityId, [In] string packageFullName);
	}
}
