using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Management.Deployment
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DeploymentResult : IDeploymentResult
	{
		public extern Guid ActivityId
		{
			get;
		}
		public extern string ErrorText
		{
			get;
		}
		public extern HResult ExtendedErrorCode
		{
			get;
		}
	}
}
