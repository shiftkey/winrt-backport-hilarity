using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[Guid(2984119974u, 8340, 18317, 135, 164, 139, 149, 32, 15, 133, 198), Version(100794368u)]
	public interface IMediaProtectionServiceRequest
	{
		Guid ProtectionSystem
		{
			get;
		}
		Guid Type
		{
			get;
		}
	}
}
