using System;
using Windows.Foundation.Metadata;
namespace Windows.Management.Deployment
{
	[Version(100794368u)]
	public struct DeploymentProgress
	{
		public DeploymentProgressState state;
		public uint percentage;
	}
}
