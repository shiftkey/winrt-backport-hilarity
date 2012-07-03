using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Protection
{
	[ExclusiveTo(typeof(MediaProtectionServiceCompletion)), Guid(2338114072u, 53205, 17646, 162, 237, 223, 118, 1, 12, 20, 181), Version(100794368u)]
	internal interface IMediaProtectionServiceCompletion
	{
		void Complete([In] bool success);
	}
}
