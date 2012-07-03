using System;
using Windows.Foundation.Metadata;
namespace Windows.Management.Deployment
{
	[ExclusiveTo(typeof(PackageUserInformation)), Guid(4130878499u, 64009, 19644, 144, 85, 21, 202, 39, 94, 46, 126), Version(100794368u)]
	internal interface IPackageUserInformation
	{
		PackageInstallState InstallState
		{
			get;
		}
		string UserSecurityId
		{
			get;
		}
	}
}
