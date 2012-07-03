using System;
using Windows.Foundation.Metadata;
namespace Windows.Management.Deployment
{
	[Flags, Version(100794368u)]
	public enum DeploymentOptions : uint
	{
		None = 0u,
		ForceApplicationShutdown = 1u,
		DevelopmentMode = 2u
	}
}
