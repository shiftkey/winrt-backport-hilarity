using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[ExclusiveTo(typeof(ServiceRequestedEventArgs)), Guid(875051951u, 43956, 20417, 189, 137, 147, 241, 6, 87, 58, 73), Version(100794368u)]
	internal interface IServiceRequestedEventArgs
	{
		MediaProtectionServiceCompletion Completion
		{
			get;
		}
		IMediaProtectionServiceRequest Request
		{
			get;
		}
	}
}
