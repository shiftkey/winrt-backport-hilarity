using System;
using Windows.Foundation.Metadata;
namespace Windows.Management.Deployment
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PackageUserInformation : IPackageUserInformation
	{
		public extern PackageInstallState InstallState
		{
			get;
		}
		public extern string UserSecurityId
		{
			get;
		}
	}
}
