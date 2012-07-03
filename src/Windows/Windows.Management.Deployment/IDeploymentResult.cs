using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Management.Deployment
{
	[ExclusiveTo(typeof(DeploymentResult)), Guid(627292590u, 46973, 19487, 138, 123, 32, 230, 173, 81, 94, 243), Version(100794368u)]
	internal interface IDeploymentResult
	{
		Guid ActivityId
		{
			get;
		}
		string ErrorText
		{
			get;
		}
		HResult ExtendedErrorCode
		{
			get;
		}
	}
}
