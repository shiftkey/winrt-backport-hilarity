using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[ExclusiveTo(typeof(ComponentLoadFailedEventArgs)), Guid(2509713043u, 30534, 16766, 132, 149, 240, 49, 187, 197, 134, 44), Version(100794368u)]
	internal interface IComponentLoadFailedEventArgs
	{
		MediaProtectionServiceCompletion Completion
		{
			get;
		}
		RevocationAndRenewalInformation Information
		{
			get;
		}
	}
}
