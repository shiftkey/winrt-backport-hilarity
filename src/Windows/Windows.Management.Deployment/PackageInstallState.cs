using System;
using Windows.Foundation.Metadata;
namespace Windows.Management.Deployment
{
	[Version(100794368u)]
	public enum PackageInstallState
	{
		NotInstalled,
		Staged,
		Installed
	}
}
